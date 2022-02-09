namespace LLCGUI
{
    partial class LLC
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LLC));
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClient = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.llLanguageFolder = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCurrentVersion = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.tabCommandLine = new System.Windows.Forms.TabPage();
            this.txtCopyToClipboard = new System.Windows.Forms.Button();
            this.txtCommandLine = new System.Windows.Forms.TextBox();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.pbThinh = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefreshClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabCommandLine.SuspendLayout();
            this.tabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbThinh)).BeginInit();
            this.SuspendLayout();
            // 
            // cbLanguage
            // 
            this.cbLanguage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Location = new System.Drawing.Point(6, 37);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(126, 23);
            this.cbLanguage.TabIndex = 2;
            // 
            // btnChange
            // 
            this.btnChange.Enabled = false;
            this.btnChange.Location = new System.Drawing.Point(137, 37);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(69, 23);
            this.btnChange.TabIndex = 5;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Language";
            // 
            // txtClient
            // 
            this.txtClient.AutoSize = true;
            this.txtClient.Location = new System.Drawing.Point(12, 139);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(111, 15);
            this.txtClient.TabIndex = 7;
            this.txtClient.Text = "Waiting For Client...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(212, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // llLanguageFolder
            // 
            this.llLanguageFolder.AutoSize = true;
            this.llLanguageFolder.Enabled = false;
            this.llLanguageFolder.Location = new System.Drawing.Point(6, 76);
            this.llLanguageFolder.Name = "llLanguageFolder";
            this.llLanguageFolder.Size = new System.Drawing.Size(127, 15);
            this.llLanguageFolder.TabIndex = 11;
            this.llLanguageFolder.TabStop = true;
            this.llLanguageFolder.Text = "Open Language Folder";
            this.llLanguageFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llLanguageFolder_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Version : ";
            // 
            // lblCurrentVersion
            // 
            this.lblCurrentVersion.AutoSize = true;
            this.lblCurrentVersion.Location = new System.Drawing.Point(59, 154);
            this.lblCurrentVersion.Name = "lblCurrentVersion";
            this.lblCurrentVersion.Size = new System.Drawing.Size(102, 15);
            this.lblCurrentVersion.TabIndex = 13;
            this.lblCurrentVersion.Text = "Version Goes Here";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMain);
            this.tabControl1.Controls.Add(this.tabCommandLine);
            this.tabControl1.Controls.Add(this.tabAbout);
            this.tabControl1.Location = new System.Drawing.Point(8, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(300, 122);
            this.tabControl1.TabIndex = 14;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.cbLanguage);
            this.tabMain.Controls.Add(this.btnChange);
            this.tabMain.Controls.Add(this.label1);
            this.tabMain.Controls.Add(this.llLanguageFolder);
            this.tabMain.Controls.Add(this.pictureBox1);
            this.tabMain.Location = new System.Drawing.Point(4, 24);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(292, 94);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // tabCommandLine
            // 
            this.tabCommandLine.Controls.Add(this.txtCopyToClipboard);
            this.tabCommandLine.Controls.Add(this.txtCommandLine);
            this.tabCommandLine.Location = new System.Drawing.Point(4, 24);
            this.tabCommandLine.Name = "tabCommandLine";
            this.tabCommandLine.Size = new System.Drawing.Size(292, 94);
            this.tabCommandLine.TabIndex = 2;
            this.tabCommandLine.Text = "Command Line";
            this.tabCommandLine.UseVisualStyleBackColor = true;
            // 
            // txtCopyToClipboard
            // 
            this.txtCopyToClipboard.Location = new System.Drawing.Point(173, 3);
            this.txtCopyToClipboard.Name = "txtCopyToClipboard";
            this.txtCopyToClipboard.Size = new System.Drawing.Size(114, 23);
            this.txtCopyToClipboard.TabIndex = 1;
            this.txtCopyToClipboard.Text = "Copy To Clipboard";
            this.txtCopyToClipboard.UseVisualStyleBackColor = true;
            this.txtCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // txtCommandLine
            // 
            this.txtCommandLine.Location = new System.Drawing.Point(3, 32);
            this.txtCommandLine.Multiline = true;
            this.txtCommandLine.Name = "txtCommandLine";
            this.txtCommandLine.Size = new System.Drawing.Size(286, 59);
            this.txtCommandLine.TabIndex = 0;
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.label5);
            this.tabAbout.Controls.Add(this.pbThinh);
            this.tabAbout.Controls.Add(this.label4);
            this.tabAbout.Controls.Add(this.label3);
            this.tabAbout.Location = new System.Drawing.Point(4, 24);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbout.Size = new System.Drawing.Size(292, 94);
            this.tabAbout.TabIndex = 1;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 30);
            this.label5.TabIndex = 3;
            this.label5.Text = "<--- This is\r\ntôi đốt tiền vào bandcamp/suruya#6941";
            // 
            // pbThinh
            // 
            this.pbThinh.Image = global::LLCGUI.Properties.Resources.vivaldi_uggeTkIy9u;
            this.pbThinh.Location = new System.Drawing.Point(6, 38);
            this.pbThinh.Name = "pbThinh";
            this.pbThinh.Size = new System.Drawing.Size(48, 47);
            this.pbThinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbThinh.TabIndex = 2;
            this.pbThinh.TabStop = false;
            this.pbThinh.Click += new System.EventHandler(this.pbThinh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "A simple LOL Language Changer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Made by johnnymc2001@gmail.com";
            // 
            // btnRefreshClient
            // 
            this.btnRefreshClient.Location = new System.Drawing.Point(215, 146);
            this.btnRefreshClient.Name = "btnRefreshClient";
            this.btnRefreshClient.Size = new System.Drawing.Size(89, 23);
            this.btnRefreshClient.TabIndex = 15;
            this.btnRefreshClient.Text = "Refresh Client";
            this.btnRefreshClient.UseVisualStyleBackColor = true;
            this.btnRefreshClient.Click += new System.EventHandler(this.btnRefreshClient_Click);
            // 
            // LLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(311, 172);
            this.Controls.Add(this.btnRefreshClient);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblCurrentVersion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LLC";
            this.Text = "LOL Language Changer";
            this.Load += new System.EventHandler(this.LLC_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.tabCommandLine.ResumeLayout(false);
            this.tabCommandLine.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbThinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbLanguage;
        private Button btnChange;
        private Label label1;
        private Label txtClient;
        private PictureBox pictureBox1;
        private LinkLabel llLanguageFolder;
        private Label label2;
        private Label lblCurrentVersion;
        private TabControl tabControl1;
        private TabPage tabMain;
        private TabPage tabAbout;
        private Label label4;
        private Label label3;
        private Label label5;
        private PictureBox pbThinh;
        private TabPage tabCommandLine;
        private TextBox txtCommandLine;
        private Button txtCopyToClipboard;
        private Button btnRefreshClient;
    }
}