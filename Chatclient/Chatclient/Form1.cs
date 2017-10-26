using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Chatclient
{
    public partial class Form1 : Form
    {

        Controller controller;
        String username;

        public Form1(Controller con)
        {
            controller = con;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            username = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.login();
        }

        public string getUserName()
        {
            return username;
        }
    }
}
