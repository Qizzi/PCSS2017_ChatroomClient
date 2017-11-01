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

        private Boolean isConnected;

        private connectWin form;
        private Lobby lobby;
        private NewRoom newroom;

        public Controller()
        {
            var loginScreen = new Thread(loginInit);
            loginScreen.Start();
        }

        /*public void createLobThread()
        {
            client = new TcpClient();
            client.Connect("localhost", 5555);

            sWriter = new StreamWriter(client.GetStream(), Encoding.ASCII);
            isConnected = true;
            String sData = null;

            while (isConnected)
            {
                sData = form.getUserName();
                sWriter.WriteLine(sData);
                sWriter.Flush();
            }

            var lobbyThread = new Thread(showLobby);
            lobbyThread.Start();
        }*/

        private void loginInit()
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

        public void login()
        {
            client = new TcpClient();
            client.Connect("localhost", 5555);

            sWriter = new StreamWriter(client.GetStream(), Encoding.ASCII);
            isConnected = true;
            String sData = null;

            if (isConnected)
            {
                sData = form.getUserName();
                sWriter.WriteLine(sData);
                sWriter.Flush();
                var lobbyThread = new Thread(showLobby);
                lobbyThread.Start();
            }
        }
    }
    
}

