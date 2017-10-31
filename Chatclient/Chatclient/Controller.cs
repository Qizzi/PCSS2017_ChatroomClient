using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
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

        public Controller()
        {
            form = new connectWin(this);
            Application.Run(form);
            
        }

        public void login()
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

        }


    }
}
