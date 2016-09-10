using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace sImageTrans
{
    public class ImageTrans
    {
        public sUdpLib.UDPNetComm m_udpComm = null;
        private int m_nMaxSendSize = 50*1024;                                   //一次最大传输50k图片
        public ImageTrans()
        {
            m_udpComm = new sUdpLib.UDPNetComm();
        }

        public void SendImage(Image image)
        {
            //SaveImage(image);
            byte[] imagebytes = sImageConvert.ImageConvert.ImageToBytes(image, System.Drawing.Imaging.ImageFormat.Jpeg);
            int nImageSize = imagebytes.Length;
            //SendImageData(imagebytes);

            //m_udpComm.SendData(imagebytes, imagebytes.Length);
            int nSendedLen = 0;
            SendImageData(imagebytes, nSendedLen);




        }


         /// <summary>
         /// 
         /// </summary>
         /// <param name="imagedata">图像数据</param>
        /// <param name="nSendedLen">已经发送的图像数据长度</param>
        void SendImageData(byte[] imagedata,int nSendedLen)
        {

            //if (imagedata.Length <= m_nMaxSendSize)
            //{
            //    m_udpComm.SendData(imagedata, imagedata.Length);
            //    nSendedLen += imagedata.Length;
            //}
            //else
            //{
            int nMoreLen = imagedata.Length - nSendedLen;
            if (nMoreLen <= 0)
                return;

            int nSendLen = nMoreLen >= m_nMaxSendSize ? m_nMaxSendSize : nMoreLen;      //剩余的数据长度

            byte[] sendbuff = new byte[nSendLen];
            Array.Copy(imagedata, nSendedLen, sendbuff, 0, sendbuff.Length);         //剩余数据拷贝到要发送的数据中
            m_udpComm.SendData(sendbuff, sendbuff.Length);
            nSendedLen += sendbuff.Length;


            SendImageData(imagedata, nSendedLen);
            //}
        }

    }
}
