using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace sImageTrans
{
    public class PicboxCtrl
    {
        public void ClearPictureImage(PictureBox picbox )
        {
            try
            {
                Graphics g = Graphics.FromImage(picbox.Image);
                g.Clear(picbox.BackColor);
                g.Dispose();
                picbox.Refresh();
            }
            catch (Exception e)
            {
                Debug.Print("ClearPicturebox: " + e.Message);
            }
        }

        public void ClearPictureBackImage(PictureBox picbox)
        {
            Graphics g = Graphics.FromImage(picbox.BackgroundImage);
            g.Clear(Color.Transparent);
            g.Dispose();
            picbox.Refresh();
            picbox.Image = null;
            picbox.Refresh();
        }
    }
}
