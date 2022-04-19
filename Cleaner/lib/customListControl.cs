using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cleaner.lib
{
    public partial class customListControl : UserControl
    {
        public customListControl()
        {
            InitializeComponent();
            Panel mPanl = new Panel();
            mPanl.Parent = this;
            mPanl.Dock = DockStyle.Fill;
            CreateList(mPanl, "Temp ");

        }

        void CreateList(Control parent,String name)
        {
            Panel rootpanel = new Panel();
            rootpanel.Dock = DockStyle.Top;
            rootpanel.Parent = parent;
            rootpanel.Name = name;

            
        }
    }
}
