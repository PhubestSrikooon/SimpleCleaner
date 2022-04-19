using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Cleaner.lib
{
    internal class buttonWDetail1 : Button
    {
        Rectangle imageRectangle;

        // Import app setting
        classes.appSetting ap = new classes.appSetting();

        public Bitmap sideImage { get; set; } = SystemIcons.Question.ToBitmap();
        public Font MainFont;
        public Font SubFont;


        public string subtitle { get; set; } = "This is subtitle";
        
        public buttonWDetail1()
        {
            setData();
        }

        void setData()
        {
            MainFont = new Font(ap.mainFont, 12.0f);
            SubFont = new Font(ap.mainFont, 9.0f);
            this.Font = MainFont;
            this.TextAlign = ContentAlignment.MiddleLeft;

        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            // Base text
            this.Padding = new Padding(this.Height, 0, 0, 20);
            imageRectangle = new Rectangle(0, 0, this.Height, this.Height);
            pevent.Graphics.DrawImage(sideImage, imageRectangle);

            // Subtitle
            pevent.Graphics.DrawString(subtitle, SubFont, ap.BlackBrush,new Point(this.Height+7, this.Height/2));
            

        }
    }
}
