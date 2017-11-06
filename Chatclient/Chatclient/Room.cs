using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chatclient
{
    public partial class Room : Form
    {
        Controller controller;
        string msg;

        public Room(Controller con)
        {
            controller = con;
            InitializeComponent();
        }

        private void Room_Load(object sender, EventArgs e)
        {

        }

        private void msgBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            controller.sendData("handleMessage");
        }

        public void listen(string n)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(listen), new object[] { n });
                return;
            }

            msgBox.AppendText(n+"\n");
        }

        private void msgInputBox_TextChanged(object sender, EventArgs e)
        {
            msg = msgBox.Text;

        }
    }
}
