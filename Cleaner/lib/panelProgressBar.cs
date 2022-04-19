using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Cleaner.lib
{
    internal class panelProgressBar : ProgressBar
    {
        classes.appSetting ap = new classes.appSetting();
        public bool isfound { get; set; } = false;
        public string mainTitle { get; set; } = "This is main title";
        public string subTitle { get; set; } = "This is sub title";

        Rectangle process_Rec;



        // Fix lib flicker
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams result = base.CreateParams;
                result.ExStyle |= 0x02000000; // WS_EX_COMPOSITED 
                return result;
            }
        }



        public panelProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.BackColor = ap.t1Gray;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            int width_percent = this.Width * this.Value/100; 
            Color barColor = isfound ? ap.t1Red : ap.t1Green;

            // Progress bar
            process_Rec = new Rectangle(0,0,width_percent,this.Height);
            pevent.Graphics.FillRectangle(new SolidBrush(barColor), process_Rec);

            // Paint text
            DrawText(pevent);
            base.OnPaint(pevent);
        }

        private void DrawText(PaintEventArgs pe)
        {
            Font pcF = new Font(ap.mainFont, 20f, FontStyle.Bold);
            string pT = $"{this.Value}%";
            Point pText_cPoint = new Point(this.Height / 2, this.Height / 2);

            // Percent text
            pe.Graphics.DrawString(pT,pcF,ap.WhiteBrush,pText_cPoint,ap.textCC);

            // Info text
            Font inf1 = new Font(ap.mainFont, 15f);
            var infp1Size = TextRenderer.MeasureText(mainTitle, inf1);
            Point infp1 = new Point(this.Height, this.Height / 2 - infp1Size.Height);            
            pe.Graphics.DrawString(mainTitle,inf1, ap.WhiteBrush,infp1);

            Font inf2 = new Font(ap.mainFont, 10f);
            var infp2Size = TextRenderer.MeasureText(subTitle, inf2);
            Point infp2 = new Point(this.Height + 2, this.Height / 2 );
            pe.Graphics.DrawString(subTitle, inf2, ap.WhiteBrush, infp2);
        }


    }
}
