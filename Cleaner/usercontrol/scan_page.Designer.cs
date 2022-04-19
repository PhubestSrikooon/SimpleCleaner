namespace Cleaner.usercontrol
{
    partial class scan_page
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelProgressBar1 = new Cleaner.lib.panelProgressBar();
            this.customListControl1 = new Cleaner.lib.customListControl();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 478);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 50);
            this.panel1.TabIndex = 2;
            // 
            // panelProgressBar1
            // 
            this.panelProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.panelProgressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProgressBar1.isfound = false;
            this.panelProgressBar1.Location = new System.Drawing.Point(0, 0);
            this.panelProgressBar1.mainTitle = "Found 1.56 GB";
            this.panelProgressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.panelProgressBar1.Name = "panelProgressBar1";
            this.panelProgressBar1.Size = new System.Drawing.Size(412, 102);
            this.panelProgressBar1.subTitle = "C:/Users/Admis/AppData/.Roaming";
            this.panelProgressBar1.TabIndex = 1;
            // 
            // customListControl1
            // 
            this.customListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customListControl1.Location = new System.Drawing.Point(0, 102);
            this.customListControl1.Name = "customListControl1";
            this.customListControl1.Size = new System.Drawing.Size(412, 376);
            this.customListControl1.TabIndex = 3;
            // 
            // scan_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customListControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelProgressBar1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "scan_page";
            this.Size = new System.Drawing.Size(412, 528);
            this.ResumeLayout(false);

        }

        #endregion

        private lib.panelProgressBar panelProgressBar1;
        private System.Windows.Forms.Panel panel1;
        private lib.customListControl customListControl1;
    }
}
