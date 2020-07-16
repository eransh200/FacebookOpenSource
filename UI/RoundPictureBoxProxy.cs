using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A20_Ex01_HarelLevi_308549807_EranShmuel_205477383.UI
{
    public class RoundPictureBoxProxy : PictureBox
    {
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            using (GraphicsPath greaphicsPath = new GraphicsPath())
            {
                greaphicsPath.AddEllipse(new Rectangle(0, 0, this.Width - 1, this.Height - 1));
                this.Region = new Region(greaphicsPath);
            }
        }
    }
}
