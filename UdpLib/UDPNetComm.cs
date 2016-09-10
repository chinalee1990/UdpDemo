using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
//using MyThreadDll;

namespace sUdpLib
{
    public class UDPNetComm
    {
     //   private MyThread m_thread;

        public UdpClient m_UdpClient;

        public SendOrPostCallback m_callback;
        public SynchronizationContext m_SyncContext = null;

        String m_strLocalIp, m_strRemoteIP;
        int m_nLocalPort, m_nRemotePort;

        public int m_Sendcounter = 0;
        public int m_RecvCount = 0;

        byte[] m_recvBuffer = new byte[10 * 1024];

        public String GetHostName()
        {
            return Dns.GetHostName();
        }

        public String GetIPAddress()
        {
            string strLocalHostName = GetHostName();
            IPHostEntry LocalHost = Dns.GetHostEntry(strLocalHostName);

            for (int i = 0; i < LocalHost.AddressList.Length; i++)
            {
                if (LocalHost.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                {
                    return LocalHost.AddressList[i].ToString();
                }
            }
            return "";
        }


        //初始化通信实例
        public void InitCommInstance(String strIpAddress, int nPort)
        {
            SetLocalPoint(strIpAddress, nPort);
            IPEndPoint LocalPoint = new IPEndPoint(IPAddress.Parse(m_strLocalIp), m_nLocalPort);
            m_UdpClient = new UdpClient(LocalPoint);
        }

        void SetLocalPoint(String strIpAddress, int nPort)
        {
            m_strLocalIp = strIpAddress;
            m_nLocalPort = nPort;
        }

        //设置远程通信终端
        public void SetRemotePoint(String strIpAddress, int nPort)
        {
            m_strRemoteIP = strIpAddress;
            m_nRemotePort = nPort;
        }

        /*********************************发送数据***********************************/

        //发送数据
        public bool SendData(byte[] sendbuffer,int nLen)
        {
             try
            {
                //发送数据
                IPEndPoint RemotePoint = new IPEndPoint(IPAddress.Parse(m_strRemoteIP), m_nRemotePort);     //远程端口
                m_UdpClient.BeginSend(sendbuffer, nLen, RemotePoint, new AsyncCallback(SendCallback), m_UdpClient);
             }
            catch
            {
                return false;
            }
            m_Sendcounter++;
            return true;
        }

        public void CloseComm()
        {
            m_UdpClient.Close();
        }

        //发送数据
        public bool SendData(String strSend)
        {
            try
            {
                //发送数据
                IPEndPoint RemotePoint = new IPEndPoint(IPAddress.Parse(m_strRemoteIP), m_nRemotePort);     //远程端口
                byte[] bySendBuffer = Encoding.UTF8.GetBytes(strSend);
                m_UdpClient.BeginSend(bySendBuffer, bySendBuffer.Length, RemotePoint, new AsyncCallback(SendCallback), m_UdpClient);
            }
            catch
            {
                return false;
            }

            m_Sendcounter++;
            return true;
        }


        //发送数据回调函数
        private static void SendCallback(IAsyncResult iar)
        {
            try
            {
                UdpClient udpClient = (UdpClient)iar.AsyncState;
                int bytesSent = udpClient.EndSend(iar);

            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
            }
        }

        /*********************************接收数据***********************************/

        //接收数据
        public void BeginReceiveData(SendOrPostCallback callback)
        {
            m_callback = callback;

            m_UdpClient.BeginReceive(new AsyncCallback(ReceiveCallback), m_UdpClient);             //开始接收
            m_SyncContext = SynchronizationContext.Current;
        }


        //接收数据回调函数
        private void ReceiveCallback(IAsyncResult iar)
        {
            try
            {
                UdpClient client = (UdpClient)iar.AsyncState;
                //读取接收的数据
                IPEndPoint RemotePoint = new IPEndPoint(IPAddress.Parse(m_strRemoteIP), m_nRemotePort);
                m_recvBuffer = client.EndReceive(iar, ref RemotePoint);
                String strRecv = Encoding.UTF8.GetString(m_recvBuffer);
                Array.Clear(m_recvBuffer, 0, m_recvBuffer.Length);

                ////显示接收数据
                //textBox_Recv.Invoke(m_DeleUpdateRecvTextBox, strRecv);

                m_SyncContext.Post(m_callback, strRecv);

                //Console.WriteLine(strRecv);
                Console.WriteLine("Recv Length = {0}",m_recvBuffer.Length);

                //继续接收
                client.BeginReceive(new AsyncCallback(ReceiveCallback), client);


            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
