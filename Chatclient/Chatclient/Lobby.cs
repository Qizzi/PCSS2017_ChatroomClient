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
    public partial class Lobby : Form
    {
        Controller controller;

        public Lobby(Controller con)
        {
            controller = con;
            InitializeComponent();
        }

        private void Lobby_Load(object sender, EventArgs e)
        {

        }
    }
}
