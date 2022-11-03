namespace SetupUI
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.locationtxt = new FlatUI.FlatTextBox();
            this.TitleLabel = new FlatUI.FlatLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flatButton1 = new FlatUI.FlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.startmenucheck = new System.Windows.Forms.CheckBox();
            this.copy = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.FIlesTXT = new FlatUI.FlatLabel();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flatLabel3 = new FlatUI.FlatLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.versiontxt = new FlatUI.FlatLabel();
            this.flatButton2 = new FlatUI.FlatButton();
            this.flatButton3 = new FlatUI.FlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.copy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // locationtxt
            // 
            this.locationtxt.BackColor = System.Drawing.Color.DimGray;
            this.locationtxt.FocusOnHover = false;
            this.locationtxt.Location = new System.Drawing.Point(37, 261);
            this.locationtxt.MaxLength = 32767;
            this.locationtxt.Multiline = false;
            this.locationtxt.Name = "locationtxt";
            this.locationtxt.ReadOnly = false;
            this.locationtxt.Size = new System.Drawing.Size(440, 29);
            this.locationtxt.TabIndex = 0;
            this.locationtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.locationtxt.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.locationtxt.UseSystemPasswordChar = false;
            this.locationtxt.TextChanged += new System.EventHandler(this.flatTextBox1_TextChanged);
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Black;
            this.TitleLabel.Location = new System.Drawing.Point(49, 84);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(428, 65);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Installer";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleLabel.Click += new System.EventHandler(this.Title_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(164, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 66);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel2.ForeColor = System.Drawing.Color.Black;
            this.flatLabel2.Location = new System.Drawing.Point(195, 214);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(109, 20);
            this.flatLabel2.TabIndex = 3;
            this.flatLabel2.Text = "Install Location";
            this.flatLabel2.Click += new System.EventHandler(this.flatLabel2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.copy);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-8, -27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(517, 579);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyDown);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage2.Controls.Add(this.versiontxt);
            this.tabPage2.Controls.Add(this.flatButton1);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.flatLabel2);
            this.tabPage2.Controls.Add(this.locationtxt);
            this.tabPage2.Controls.Add(this.TitleLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(509, 553);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Init";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton1.Location = new System.Drawing.Point(387, 492);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = false;
            this.flatButton1.Size = new System.Drawing.Size(106, 32);
            this.flatButton1.TabIndex = 1;
            this.flatButton1.Text = "Install";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton1.Click += new System.EventHandler(this.flatButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.startmenucheck);
            this.groupBox1.Location = new System.Drawing.Point(164, 383);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 52);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // startmenucheck
            // 
            this.startmenucheck.AutoSize = true;
            this.startmenucheck.Location = new System.Drawing.Point(28, 19);
            this.startmenucheck.Name = "startmenucheck";
            this.startmenucheck.Size = new System.Drawing.Size(112, 17);
            this.startmenucheck.TabIndex = 0;
            this.startmenucheck.Text = "Add to Start Menu";
            this.startmenucheck.UseVisualStyleBackColor = true;
            this.startmenucheck.CheckedChanged += new System.EventHandler(this.startmenucheck_CheckedChanged);
            // 
            // copy
            // 
            this.copy.BackColor = System.Drawing.Color.DarkGray;
            this.copy.Controls.Add(this.richTextBox1);
            this.copy.Controls.Add(this.pictureBox2);
            this.copy.Controls.Add(this.FIlesTXT);
            this.copy.Controls.Add(this.flatLabel1);
            this.copy.Location = new System.Drawing.Point(4, 22);
            this.copy.Name = "copy";
            this.copy.Padding = new System.Windows.Forms.Padding(3);
            this.copy.Size = new System.Drawing.Size(509, 553);
            this.copy.TabIndex = 2;
            this.copy.Text = "copy";
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.richTextBox1.Location = new System.Drawing.Point(10, 168);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(484, 189);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(164, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 66);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FIlesTXT
            // 
            this.FIlesTXT.BackColor = System.Drawing.Color.Transparent;
            this.FIlesTXT.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.FIlesTXT.ForeColor = System.Drawing.Color.Black;
            this.FIlesTXT.Location = new System.Drawing.Point(52, 210);
            this.FIlesTXT.Name = "FIlesTXT";
            this.FIlesTXT.Size = new System.Drawing.Size(379, 18);
            this.FIlesTXT.TabIndex = 2;
            this.FIlesTXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FIlesTXT.Click += new System.EventHandler(this.FIlesTXT_Click);
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel1.ForeColor = System.Drawing.Color.Black;
            this.flatLabel1.Location = new System.Drawing.Point(161, 108);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(179, 50);
            this.flatLabel1.TabIndex = 1;
            this.flatLabel1.Text = "Installing.";
            this.flatLabel1.Click += new System.EventHandler(this.flatLabel1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage1.Controls.Add(this.flatButton3);
            this.tabPage1.Controls.Add(this.flatButton2);
            this.tabPage1.Controls.Add(this.flatLabel3);
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(509, 553);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "done";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // flatLabel3
            // 
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel3.ForeColor = System.Drawing.Color.Black;
            this.flatLabel3.Location = new System.Drawing.Point(184, 106);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(129, 40);
            this.flatLabel3.TabIndex = 4;
            this.flatLabel3.Text = "Finished!";
            this.flatLabel3.Click += new System.EventHandler(this.flatLabel3_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(159, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(176, 66);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // versiontxt
            // 
            this.versiontxt.BackColor = System.Drawing.Color.Transparent;
            this.versiontxt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.versiontxt.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.versiontxt.ForeColor = System.Drawing.Color.Black;
            this.versiontxt.Location = new System.Drawing.Point(3, 527);
            this.versiontxt.Name = "versiontxt";
            this.versiontxt.Size = new System.Drawing.Size(503, 23);
            this.versiontxt.TabIndex = 1;
            this.versiontxt.Text = "N/A";
            this.versiontxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flatButton2
            // 
            this.flatButton2.BackColor = System.Drawing.Color.Transparent;
            this.flatButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton2.Location = new System.Drawing.Point(16, 502);
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.Rounded = false;
            this.flatButton2.Size = new System.Drawing.Size(106, 32);
            this.flatButton2.TabIndex = 5;
            this.flatButton2.Text = "Open Folder";
            this.flatButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton2.Click += new System.EventHandler(this.flatButton2_Click);
            // 
            // flatButton3
            // 
            this.flatButton3.BackColor = System.Drawing.Color.Transparent;
            this.flatButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton3.Location = new System.Drawing.Point(387, 502);
            this.flatButton3.Name = "flatButton3";
            this.flatButton3.Rounded = false;
            this.flatButton3.Size = new System.Drawing.Size(106, 32);
            this.flatButton3.TabIndex = 6;
            this.flatButton3.Text = "Exit";
            this.flatButton3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton3.Click += new System.EventHandler(this.flatButton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(501, 545);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Installer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.copy.ResumeLayout(false);
            this.copy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FlatTextBox locationtxt;
        private FlatUI.FlatLabel TitleLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FlatUI.FlatLabel flatLabel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox startmenucheck;
        private System.Windows.Forms.TabPage copy;
        private FlatUI.FlatLabel flatLabel1;
        private FlatUI.FlatButton flatButton1;
        private FlatUI.FlatLabel FIlesTXT;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private FlatUI.FlatLabel flatLabel3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private FlatUI.FlatLabel versiontxt;
        private FlatUI.FlatButton flatButton3;
        private FlatUI.FlatButton flatButton2;
    }
}

