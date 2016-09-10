using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using sUdpLib;
using MyThreadDll;

namespace UdpServerDemo
{
    public partial class FormComm : Form
    {
        UDPNetComm udpComm1 = new UDPNetComm();
        private MyThread m_thread;

        String m_strLocalIp;
        int m_nLocalPort = 6002;

        public delegate void DeleUpdateTextbox(string strText);                                     //接收信息更新显示代理
        DeleUpdateTextbox m_DeleUpdateRecvTextBox;

        public FormComm()
        {
            InitializeComponent();
            m_thread = new MyThread();
            m_thread.m_threadstart = new ThreadStart(ThreadFunc);

            textBox_Send.Text = "H01_A_02.000_T  H01_B_01.000_T";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_strLocalIp = udpComm1.GetIPAddress();
            textBox_RemoteIP.Text = m_strLocalIp;
            textBox_RemotePort.Text = "7000";
            textBox_LocalPort.Text = "6000";
            timer1.Enabled = true;
        }

        private void button_Set_Click(object sender, EventArgs e)
        {
            int nRemotePort = Convert.ToInt32(textBox_RemotePort.Text);
            String strRemoteIp = textBox_RemoteIP.Text;
            m_nLocalPort = Convert.ToInt32(textBox_LocalPort.Text);
            try
            {
                udpComm1.InitCommInstance(m_strLocalIp, m_nLocalPort);

                m_DeleUpdateRecvTextBox = new DeleUpdateTextbox(OnUpdateRecvTextBox);
            }
            catch
            {
                OnUpdateRecvTextBox("网络连接异常");
                return;
            }

            udpComm1.SetRemotePoint(strRemoteIp, nRemotePort);
            udpComm1.BeginReceiveData(OnUpdateRecvTextBox, false);
            button_Set.Enabled = false;
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            if (!udpComm1.SendData(textBox_Send.Text))
            {
                OnUpdateRecvTextBox("发送数据失败");
            }
        }

        private void OnClose(object sender, FormClosedEventArgs e)
        {
            m_thread.EndRun();
            if (button_Set.Enabled == false)
            {

              udpComm1.CloseComm();

            }

        }

        //更新接收文本框
        private void OnUpdateRecvTextBox(Object strText)
        {
            udpComm1.m_RecvCount++;
            richTextBox_Recv.Text = strText.ToString() + "\r\n================";


            //UpdateRecvCount();
            //textBox_Recv.AppendText(strText.ToString() + "\r\n");
            //UpdateRecvCount();
        }

        private void ThreadFunc()
        {
           
            while (m_thread.isRun())
            {
                //byte[] SendBuffer = new byte[6] { 0XAB, 0X01, 0X14, 0X22, 0X75, 0XCD };
                //udpComm1.SendData(SendBuffer, SendBuffer.Length);
                String strSend = textBox_Send.Text;
                udpComm1.SendData(strSend);
                Thread.Sleep(10);
            }
        }

        private void btnTimerSend_Click(object sender, EventArgs e)
        {
            if (btnTimerSend.Text == "定时发送")
            {
                m_thread.StartRun();
                btnTimerSend.Text = "结束定时发送";
            }
            else if (btnTimerSend.Text == "结束定时发送")
            {
                m_thread.EndRun();
                btnTimerSend.Text = "定时发送";
            }
        }

        void UpdateSendCount()
        {
            label_SendCount.Text = "SendCount = " + udpComm1.m_Sendcounter.ToString();
        }

        void UpdateRecvCount()
        {
            label_RecvCount.Text = "RecvCount = " + udpComm1.m_RecvCount.ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateSendCount();
            UpdateRecvCount();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            udpComm1.m_Sendcounter = 0;
            udpComm1.m_RecvCount = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox_Recv.Text = "";
            richTextBox_Recv.Text = "";
        }

        private void button_ClearSend_Click(object sender, EventArgs e)
        {
            textBox_Send.Text = "";
        }
    }
}
