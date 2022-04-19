using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.classes
{
    internal class appSetting
    {
        public Color ForeColorWhite = Color.Black;
        public Color BackColorWhite = Color.White;
        public Color subWhite = Color.FromArgb(100,200,200,200);

        public Color ForeColorBlack = Color.White;
        public Color BackColorBlack = Color.FromArgb(100,10,10,10);
        public Color subBlack = Color.FromArgb(100, 20, 20, 20);

        public Color t1Green = Color.FromArgb(78, 205, 196);
        public Color t1Red = Color.FromArgb(255, 107, 107);
        public Color t1Gray = Color.FromArgb(41, 47 , 54); 

        public Brush BlackBrush = new SolidBrush(Color.Black);
        public Brush WhiteBrush = new SolidBrush(Color.White);
        public StringFormat textCC = new StringFormat();
        public StringFormat textCL = new StringFormat();

        public string mainFont = "Segoe Ui";

        void SetValue()
        {
            textCC.LineAlignment = StringAlignment.Center;
            textCC.Alignment = StringAlignment.Center;
            textCL.LineAlignment = StringAlignment.Center;
            textCL.Alignment = StringAlignment.Near;
        }
        public appSetting()
        {
            SetValue();
        }
    }
}
