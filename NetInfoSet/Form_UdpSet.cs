using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sUdpSetLib
{
    public partial class Form_UdpSet : Form
    {
        public string m_strLocalIp;
        public int m_nLocalPort;

        public string m_strRemoteIp;
        public int m_nRemotePort;
        public Form_UdpSet()
        {
            InitializeComponent();
        }


        private void button_Ok_Click(object sender, EventArgs e)
        {
            try
            {
                m_strLocalIp = textBox_LocalIp.Text;
                m_nLocalPort = int.Parse(textBox_LocalPort.Text);

                m_strRemoteIp = textBox_RemoteIp.Text;
                m_nRemotePort = int.Parse(textBox_RemotePort.Text);
                this.Close();
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);
                return;
            }
        }


        public void SetLocalInfo(string strIp,int nPort)
        {
            textBox_LocalIp.Text = strIp;
            textBox_LocalPort.Text = nPort.ToString();
        }

        public void SetRemoteInfo(string strIp, int nPort)
        {
            textBox_RemoteIp.Text = strIp;
            textBox_RemotePort.Text = nPort.ToString();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
