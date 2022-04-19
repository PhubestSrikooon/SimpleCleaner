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
    public partial class scan_page : UserControl
    {
        static usercontrol.scan_page _obj;
        public static usercontrol.scan_page Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new usercontrol.scan_page();
                }
                return _obj;
            }
        }
        public scan_page()
        {
            InitializeComponent();
        }

        
    }
}
