using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cleaner.usercontrol
{
    public partial class simpleForm : UserControl
    {
        classes.appSetting AppSetting = new classes.appSetting();
        public simpleForm()
        {
            InitializeComponent();
        }

        private void scan_btn_MouseDown(object sender, MouseEventArgs e)
        {
            var f1_inst = MainForm.Instance;
            if (!f1_inst.Controls.ContainsKey("scan_page"))
            {
                usercontrol.scan_page sp = new scan_page();
                sp.Dock = DockStyle.Fill;
                f1_inst.PnlContainer.Controls.Add(sp);
            }
            f1_inst.PnlContainer.Controls["scan_page"].BringToFront();
            
        }
    }
}
