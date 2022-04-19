using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cleaner
{
    public partial class MainForm : Form
    {
        static MainForm _obj;
        public static MainForm Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new MainForm();
                }
                return _obj;
            }
        }
        public Panel PnlContainer
        {
            get { return control; }
            set { control = value; }
        }

        UserControl simpleControl;
        classes.fileDetection fileDetection;
        public MainForm()
        {
            InitializeComponent();
            startUp();
        }

        private void startUp()
        {
            fileDetection = new classes.fileDetection();
            simpleControl = new Cleaner.usercontrol.simpleForm();
            simpleControl.Dock = DockStyle.Fill;
            control.Controls.Clear();
            control.Controls.Add(simpleControl);

            _obj = this;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult msgexit = MessageBox.Show("Are you sure you want to close?\n If you close the scan going to cancel","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (msgexit == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (msgexit == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
