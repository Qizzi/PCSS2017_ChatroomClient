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
        private NewRoom newroom;

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

        public void showNewRoomForm()
        {
            newroom = new NewRoom(this);
            Application.Run(newroom);

        }

        public void initNewRoom()
        {
            var createRoomForm = new Thread(showNewRoomForm);
            createRoomForm.Start();
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
                lobbyThread.Start();
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
    }
    
}

