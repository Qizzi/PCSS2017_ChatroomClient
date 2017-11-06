using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chatclient
{
    public partial class Room : Form
    {
        Controller controller;

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
    }
}
