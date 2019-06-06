namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSS = new System.Windows.Forms.Button();
            this.tbDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangefolder = new System.Windows.Forms.Button();
            this.btnOpenfolder = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Exit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbHotkey = new System.Windows.Forms.CheckBox();
            this.tbHot = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Exit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSS
            // 
            this.btnSS.Location = new System.Drawing.Point(12, 170);
            this.btnSS.Name = "btnSS";
            this.btnSS.Size = new System.Drawing.Size(136, 37);
            this.btnSS.TabIndex = 0;
            this.btnSS.Text = "Take a screenshot";
            this.btnSS.UseVisualStyleBackColor = true;
            this.btnSS.Click += new System.EventHandler(this.BtnSS_Click);
            // 
            // tbDir
            // 
            this.tbDir.Location = new System.Drawing.Point(12, 83);
            this.tbDir.Name = "tbDir";
            this.tbDir.ReadOnly = true;
            this.tbDir.Size = new System.Drawing.Size(310, 20);
            this.tbDir.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Saving directory:";
            // 
            // btnChangefolder
            // 
            this.btnChangefolder.Location = new System.Drawing.Point(328, 81);
            this.btnChangefolder.Name = "btnChangefolder";
            this.btnChangefolder.Size = new System.Drawing.Size(95, 23);
            this.btnChangefolder.TabIndex = 3;
            this.btnChangefolder.Text = "Change folder";
            this.btnChangefolder.UseVisualStyleBackColor = true;
            this.btnChangefolder.Click += new System.EventHandler(this.BtnChangefolder_Click);
            // 
            // btnOpenfolder
            // 
            this.btnOpenfolder.Location = new System.Drawing.Point(12, 117);
            this.btnOpenfolder.Name = "btnOpenfolder";
            this.btnOpenfolder.Size = new System.Drawing.Size(136, 37);
            this.btnOpenfolder.TabIndex = 6;
            this.btnOpenfolder.Text = "View saving folder";
            this.btnOpenfolder.UseVisualStyleBackColor = true;
            this.btnOpenfolder.Click += new System.EventHandler(this.BtnOpenfolder_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.Exit;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Z-Capture";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
            // 
            // Exit
            // 
            this.Exit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(93, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // cbHotkey
            // 
            this.cbHotkey.AutoSize = true;
            this.cbHotkey.Location = new System.Drawing.Point(12, 225);
            this.cbHotkey.Name = "cbHotkey";
            this.cbHotkey.Size = new System.Drawing.Size(97, 17);
            this.cbHotkey.TabIndex = 8;
            this.cbHotkey.Text = "Enable hotkey ";
            this.cbHotkey.UseVisualStyleBackColor = true;
            this.cbHotkey.CheckedChanged += new System.EventHandler(this.CbHotkey_CheckedChanged_1);
            // 
            // tbHot
            // 
            this.tbHot.Location = new System.Drawing.Point(104, 223);
            this.tbHot.Name = "tbHot";
            this.tbHot.ReadOnly = true;
            this.tbHot.Size = new System.Drawing.Size(44, 20);
            this.tbHot.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(213, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(435, 258);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbHot);
            this.Controls.Add(this.cbHotkey);
            this.Controls.Add(this.btnOpenfolder);
            this.Controls.Add(this.btnChangefolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDir);
            this.Controls.Add(this.btnSS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Z-Capture";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.Exit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSS;
        private System.Windows.Forms.TextBox tbDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChangefolder;
        private System.Windows.Forms.Button btnOpenfolder;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox cbHotkey;
        private System.Windows.Forms.TextBox tbHot;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip Exit;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

