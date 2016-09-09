using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MyThreadDll
{
    public class MyThread
    {
        public Thread m_thread;
        private bool m_bWorking = false;
        public ThreadStart m_threadstart;

        //public MyThread()
        //{
        //    m_thread = new Thread(m_threadstart);
        //    m_bWorking = false;
        //}

        public void StartRun()
        {
            m_thread = new Thread(m_threadstart);
            m_thread.Start();
            m_bWorking = true;
        }

        public void EndRun()
        {
            try
            {
                m_bWorking = false;
                m_thread.Join();
            }
            catch
            {

            }
        }

        public bool isRun()
        {
            return m_bWorking;
        }

    }
}
