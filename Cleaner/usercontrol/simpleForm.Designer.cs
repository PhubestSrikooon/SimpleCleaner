namespace Cleaner.usercontrol
{
    partial class simpleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(simpleForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.setting_btn = new Cleaner.lib.buttonWDetail1();
            this.scan_btn = new Cleaner.lib.buttonWDetail1();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Cleaner.Properties.Resources.dc_banner;
            this.pictureBox1.Location = new System.Drawing.Point(59, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 363);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // setting_btn
            // 
            this.setting_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setting_btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.setting_btn.Location = new System.Drawing.Point(59, 517);
            this.setting_btn.Name = "setting_btn";
            this.setting_btn.Padding = new System.Windows.Forms.Padding(88, 0, 0, 20);
            this.setting_btn.sideImage = ((System.Drawing.Bitmap)(resources.GetObject("setting_btn.sideImage")));
            this.setting_btn.Size = new System.Drawing.Size(440, 88);
            this.setting_btn.subtitle = "Mannage your setting";
            this.setting_btn.TabIndex = 1;
            this.setting_btn.Text = "Setting";
            this.setting_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setting_btn.UseVisualStyleBackColor = true;
            // 
            // scan_btn
            // 
            this.scan_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scan_btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.scan_btn.Location = new System.Drawing.Point(59, 424);
            this.scan_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scan_btn.Name = "scan_btn";
            this.scan_btn.Padding = new System.Windows.Forms.Padding(88, 0, 0, 20);
            this.scan_btn.sideImage = global::Cleaner.Properties.Resources.hambergur1black;
            this.scan_btn.Size = new System.Drawing.Size(440, 88);
            this.scan_btn.subtitle = "Start your first scan!";
            this.scan_btn.TabIndex = 0;
            this.scan_btn.Text = "Scan for junk";
            this.scan_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scan_btn.UseVisualStyleBackColor = true;
            this.scan_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.scan_btn_MouseDown);
            // 
            // simpleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.setting_btn);
            this.Controls.Add(this.scan_btn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "simpleForm";
            this.Size = new System.Drawing.Size(550, 650);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private lib.buttonWDetail1 scan_btn;
        private lib.buttonWDetail1 setting_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
