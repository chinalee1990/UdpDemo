using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

using sUdpSetLib;


namespace UdpImage
{
    public partial class Form_SendImage : Form
    {
        string m_strTitleOld = "";
        int m_nFsp = 20;

        sImageTrans.ImageTrans m_imagetrans;
        public Form_SendImage()
        {
            InitializeComponent();
            m_imagetrans = new sImageTrans.ImageTrans();


        }

        private void Form_SendImage_Load(object sender, EventArgs e)
        {
            //设置端口信息
            Form_UdpSet setform = new Form_UdpSet();
            setform.SetLocalInfo(m_imagetrans.m_udpComm.GetIPAddress(), 6000);
            setform.SetRemoteInfo(m_imagetrans.m_udpComm.GetIPAddress(), 7000);
            setform.ShowDialog();

            //初始化通信
            m_imagetrans.m_udpComm.InitCommInstance(setform.m_strLocalIp, setform.m_nLocalPort);
            m_imagetrans.m_udpComm.SetRemotePoint(setform.m_strRemoteIp, setform.m_nRemotePort);

            m_strTitleOld = this.Text;
            UpdateWindowInfo();
        }

        private void 开始ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000 / m_nFsp;
            timer1.Enabled = true;
            UpdateWindowInfo();

        }

        private void 结束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            UpdateWindowInfo();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendScreen();
        }

        void SendScreen()
        {
            Image image = sCapScreen.CapScreen.captureScreen();
            pictureBox1.Image = image;
            //发送图像
            m_imagetrans.SendImage(image);
        }

        void SaveImage(Image image)
        {
            string strFileName = "E:\\Save" + string.Format("\\{0}.jpg", DateTime.Now.ToString("yyyyMMdd hhmmss"));
            image.Save(strFileName, System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        void UpdateWindowInfo()
        {
            if(timer1.Enabled==false)
            {
                this.Text = m_strTitleOld + "————已暂停";
            }
            else
            {
                this.Text = m_strTitleOld + "————已开始";
            }
            toolStripStatusLabel_fps.Text = string.Format("fps:{0}", m_nFsp);
        }

        private void udp设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 开始一次ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendScreen();
        }

        private void 清除图像ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sImageTrans.PicboxCtrl pc = new sImageTrans.PicboxCtrl();
            pc.ClearPictureImage(pictureBox1);
        }

        
    }
}
