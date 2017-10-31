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
    public partial class NewRoom : Form
    {
        Controller controller;
        string roomname;
    
        public NewRoom(Controller con)
        {
            controller = con;
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread.CurrentThread.Abort();

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            roomname = RoomNameTextBox.Text;
        }
    }
}
