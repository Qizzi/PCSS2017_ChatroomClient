using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chatclient
{
    public partial class Lobby : Form
    {
        Controller controller;
        string highlight = "";

        public Lobby(Controller con)
        {
            controller = con;
            InitializeComponent();
        }

        private void Lobby_Load(object sender, EventArgs e)
        {

        }
        private void createBtn_Click(object sender, EventArgs e)
        {
            controller.sendData("createRoom");
        }

        private void serverList_SelectedIndexChanged(object sender, EventArgs e)
        {
            highlight = serverList.SelectedIndex.ToString();
        }

        public void addListElement(string n)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(addListElement), new object[] { n });
                return;
            }

            serverList.Items.Add(n);
        }
        private void joinBtn_Click(object sender, EventArgs e)
        {
            controller.sendData("joinRoom");
            controller.sendData(controller.getUID().ToString());
            controller.sendData(highlight);
            controller.initRoom();
        }
    }
}
