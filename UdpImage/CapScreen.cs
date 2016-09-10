using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace sCapScreen
{
    public class CapScreen
    {

        #region 抓取屏幕
        /// <summary>
        /// 抓取屏幕(层叠的窗口)
        /// </summary>
        /// <param name="x">左上角的横坐标</param>
        /// <param name="y">左上角的纵坐标</param>
        /// <param name="width">抓取宽度</param>
        /// <param name="height">抓取高度</param>
        /// <returns></returns>
        public static Bitmap captureScreen(int x, int y, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(new Point(x, y), new Point(0, 0), bmp.Size);
                g.Dispose();
            }
            //bit.Save(@"capture2.png");
            return bmp;
        }

        /// <summary>
        /// 抓取整个屏幕
        /// </summary>
        /// <returns></returns>
        public static Bitmap captureScreen()
        {
            Size screenSize = Screen.PrimaryScreen.Bounds.Size;
            return captureScreen(0, 0, screenSize.Width, screenSize.Height);
        }
        #endregion

        #region 使用BitBlt方法抓取控件，无论控件是否被遮挡
        /// <summary>
        /// 控件(窗口)的截图，控件被其他窗口(而非本窗口内控件)遮挡时也可以正确截图，使用BitBlt方法
        /// </summary>
        /// <param name="control">需要被截图的控件</param>
        /// <returns>该控件的截图，控件被遮挡时也可以正确截图</returns>
        public static Bitmap captureControl(Control control)
        {
        //调用API截屏
            IntPtr hSrce = WindowApi.GetWindowDC(control.Handle);
            IntPtr hDest = WindowApi.CreateCompatibleDC(hSrce);
            IntPtr hBmp = WindowApi.CreateCompatibleBitmap(hSrce, control.Width, control.Height);
            IntPtr hOldBmp = WindowApi.SelectObject(hDest, hBmp);
            if (WindowApi.BitBlt(hDest, 0, 0, control.Width, control.Height, hSrce, 0, 0, CopyPixelOperation.SourceCopy | CopyPixelOperation.CaptureBlt))
            {
                Bitmap bmp = Image.FromHbitmap(hBmp);
                WindowApi.SelectObject(hDest, hOldBmp);
                WindowApi.DeleteObject(hBmp);
                WindowApi.DeleteDC(hDest);
                WindowApi.ReleaseDC(control.Handle, hSrce);
                // bmp.Save(@"a.png");
                // bmp.Dispose();
                return bmp;
            }
        return null;

        }


        #endregion


        #region 使用PrintWindow方法抓取窗口，无论控件是否被遮挡
        /// <summary>
        /// 窗口的截图，窗口被遮挡时也可以正确截图，使用PrintWindow方法
        /// </summary>
        /// <param name="control">需要被截图的窗口</param>
        /// <returns>窗口的截图，控件被遮挡时也可以正确截图</returns>
        public static Bitmap captureWindowUsingPrintWindow(Form form)
        {
           return GetWindow(form.Handle);
        }


        private static Bitmap GetWindow(IntPtr hWnd)
        {
            IntPtr hscrdc = WindowApi.GetWindowDC(hWnd);
            Control control = Control.FromHandle(hWnd);
            IntPtr hbitmap = WindowApi.CreateCompatibleBitmap(hscrdc, control.Width, control.Height);
            IntPtr hmemdc = WindowApi.CreateCompatibleDC(hscrdc);
            WindowApi.SelectObject(hmemdc, hbitmap);
            WindowApi.PrintWindow(hWnd, hmemdc, 0);
            Bitmap bmp = Bitmap.FromHbitmap(hbitmap);
            WindowApi.DeleteDC(hscrdc);//删除用过的对象
            WindowApi.DeleteDC(hmemdc);//删除用过的对象
            return bmp;
        }
        #endregion

  

    }
}
