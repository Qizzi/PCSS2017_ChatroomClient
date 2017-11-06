using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chatclient
{
    public class Controller
    {

        private TcpClient client;

        private StreamReader sReader;
        private StreamWriter sWriter;
        private String sData;

        private Boolean isConnected;

        private connectWin form;
        private Lobby lobby;
        private Room roomForm;
        private int UID;
        private string dataReceived;
        private string msgReceived;

        public Controller()
        {
            client = new TcpClient();
            var loginScreen = new Thread(initConnect);
            loginScreen.Start();
        }

        private void initConnect()
        {
            form = new connectWin(this);
            Application.Run(form);
        }

        public void showLobby()
        {
            lobby = new Lobby(this);
            Application.Run(lobby);
        }

        public void showRoomForm()
        {
            roomForm = new Room(this);
            Application.Run(roomForm);
        }

        public void initRoom()
        {
            var roomForm = new Thread(showRoomForm);
            roomForm.Start();
               
        }

        public void connect()
        {
            client.Connect("localhost", 5555);
            sWriter = new StreamWriter(client.GetStream(), Encoding.ASCII);
            sReader = new StreamReader(client.GetStream(), Encoding.ASCII);
            isConnected = true;
            String sData = null;

            if (isConnected)
            {
                sData = form.getUserName();
                sendData(sData);
                var lobbyThread = new Thread(showLobby);
                var listen = new Thread(listenForData);
                listen.Start();
                lobbyThread.Start();
                UID = Int32.Parse(sReader.ReadLine());
            }
        }

        public void sendData(string data)
        {
            sWriter.WriteLine(data);
            sWriter.Flush();
        }

       public Boolean getConStatus()
        {
            return isConnected;
        }

        public void setSdata(string data)
        {
            sData = data;
        }

        public void listenForData()
        {
            while (isConnected)
            {
                dataReceived = sReader.ReadLine();
                if (dataReceived.Contains("Room"))
                {
                    lobby.addListElement(dataReceived);
                } else
                {
                    roomForm.listen(dataReceived);
                }
                
                Console.WriteLine(sData);
            }

        }

        public void receiveMsg()
        {
            while(isConnected)
            {
                msgReceived = sReader.ReadLine();
                roomForm.listen(msgReceived);
            }
        }

        public int getUID()
        {
            return UID;
        }
    }
    
}

