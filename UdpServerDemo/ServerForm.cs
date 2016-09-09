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
    public partial class ServerForm : Form
    {
        private int m_nClientNum;
        public ServerForm()
        {
            InitializeComponent();
        }

        private void button_AddClient_Click(object sender, EventArgs e)
        {
            m_nClientNum++;
            listBox_Client.Items.Add("客户端" + m_nClientNum.ToString());
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {
            listBox_Client.Items.Add("客户端1");
            listBox_Client.Items.Add("客户端2");
            listBox_Client.Items.Add("客户端3");
            listBox_Client.Items.Add("客户端4");
            m_nClientNum = listBox_Client.Items.Count;
        }

        private void listBox_Client_DoubleClick(object sender, EventArgs e)
        {
            int nIndex = listBox_Client.SelectedIndex;
            String strClientName = listBox_Client.Items[nIndex].ToString();
            FormComm form = new FormComm();
            form.Text = "server_" + strClientName;
            form.Show(this);
        }
        
    }
}
