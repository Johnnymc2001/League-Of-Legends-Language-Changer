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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbLanguage
            // 
            this.cbLanguage.AutoCompleteCustomSource.AddRange(new string[] {
            "vn_VN",
            "ja_JP",
            "ko_KR",
            "zh_CN",
            "zh_TW",
            "es_ES",
            "es_MX",
            "en_US",
            "fr_FR",
            "de_DE",
            "it_IT",
            "pl_PL",
            "ro_RO",
            "el_GR",
            "pt_BR",
            "hu_HU",
            "ru_RU",
            "tr_TR"});
            this.cbLanguage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbLanguage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Location = new System.Drawing.Point(5, 24);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(126, 23);
            this.cbLanguage.TabIndex = 2;
            // 
            // btnChange
            // 
            this.btnChange.Enabled = false;
            this.btnChange.Location = new System.Drawing.Point(137, 24);
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
            this.txtClient.Location = new System.Drawing.Point(4, 65);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(111, 15);
            this.txtClient.TabIndex = 7;
            this.txtClient.Text = "Waiting For Client...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(212, 6);
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
            this.llLanguageFolder.Location = new System.Drawing.Point(5, 50);
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
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Version : ";
            // 
            // lblCurrentVersion
            // 
            this.lblCurrentVersion.AutoSize = true;
            this.lblCurrentVersion.Location = new System.Drawing.Point(72, 122);
            this.lblCurrentVersion.Name = "lblCurrentVersion";
            this.lblCurrentVersion.Size = new System.Drawing.Size(102, 15);
            this.lblCurrentVersion.TabIndex = 13;
            this.lblCurrentVersion.Text = "Version Goes Here";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(8, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(300, 111);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbLanguage);
            this.tabPage1.Controls.Add(this.btnChange);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.llLanguageFolder);
            this.tabPage1.Controls.Add(this.txtClient);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(292, 83);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(292, 83);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "About";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.label3.Location = new System.Drawing.Point(84, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Made by johnnymc2001@gmail.com";
            // 
            // LLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(320, 139);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblCurrentVersion);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LLC";
            this.Text = "LOL Language Changer";
            this.Load += new System.EventHandler(this.LLC_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label4;
        private Label label3;
    }
}