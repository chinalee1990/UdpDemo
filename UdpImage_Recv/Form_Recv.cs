using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using sUdpSetLib;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace UdpImage_Recv
{
    public partial class Form_Recv : Form
    {  
        sUdpLib.UDPNetComm m_udpcomm = new sUdpLib.UDPNetComm();

        public Form_Recv()
        {
            InitializeComponent();
        }

        private void Form_Recv_Load(object sender, EventArgs e)
        {
            //设置端口信息
            Form_UdpSet setform = new Form_UdpSet();
            setform.SetLocalInfo(m_udpcomm.GetIPAddress(), 7000);
            setform.SetRemoteInfo(m_udpcomm.GetIPAddress(), 6000);
            setform.ShowDialog();

            //初始化通信
            m_udpcomm.InitCommInstance(setform.m_strLocalIp, setform.m_nLocalPort);
            m_udpcomm.SetRemotePoint(setform.m_strRemoteIp, setform.m_nRemotePort);
            m_udpcomm.BeginReceiveData(OnUdpRecv, true);

        }

        public static byte[] Serialize(object data)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (MemoryStream rems = new MemoryStream())
            {
                formatter.Serialize(rems, data);
                return rems.GetBuffer();
            }
            
        } 

        void OnUdpRecv(object oRecvData)
        {
            byte[] arrRecvData = oRecvData as byte[];
            Image image = sImageConvert.ImageConvert.BytesToImage(arrRecvData);
            pictureBox1.Image = image;
        }
    }
}
