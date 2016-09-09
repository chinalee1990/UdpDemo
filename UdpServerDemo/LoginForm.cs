using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UdpServerDemo
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button_Client_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormComm form = new FormComm();
            form.Text = "Client";
            form.ShowDialog();
            this.Show();
        }

        private void button_Server_Click(object sender, EventArgs e)
        {
            this.Hide();
            ServerForm form = new ServerForm();
            form.ShowDialog();
            this.Show();
        }
    }
}
