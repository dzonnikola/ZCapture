using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Configuration;
using System.Diagnostics;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string defaultpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        //private void PickFormat()
        //{
        //    if (radioButton1.Checked)
        //        saveFileDialog.Filter = ".jpg | *.jpg";
        //    else if (radioButton2.Checked)
        //        saveFileDialog.Filter = ".png | *.png";
        //    else if (radioButton3.Checked)
        //        saveFileDialog.Filter = ".bmp | *.bmp";
        //    else if (radioButton4.Checked)
        //        saveFileDialog.Filter = ".tiff | *.tiff";
        //    else
        //        MessageBox.Show("Pick a format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}
        private void ScreenShot() //Method ScreenShot - does 95% of the job
        {
            try
            {
                saveFileDialog.InitialDirectory = defaultpath;
                saveFileDialog.Filter = ".jpg | *.jpg | .png | *.png | .tiff | *.tiff | .bmp | *.bmp";
                DialogResult result = saveFileDialog.ShowDialog();
                this.Hide();
                System.Threading.Thread.Sleep(1000);
                SendKeys.Send("{PRTSC}");
                Image img = Clipboard.GetImage();
                if (result == DialogResult.OK)
                {
                    img.Save(saveFileDialog.FileName);
                    if (saveFileDialog.FileName == "" || saveFileDialog.FileName == null)
                    {
                        MessageBox.Show("File name can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    saveFileDialog.FileName = "";
                    this.Show();
                    WindowState = FormWindowState.Normal;
                    pictureBox1.Image = img;
                }
                else
                    this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                this.Close();
            }
        }
        private void BtnSS_Click(object sender, EventArgs e) // Calling metod ScreenShot();
        {
            ScreenShot();
        }

        private void Form1_Load(object sender, EventArgs e) //In Form load there are some pre-sets 
        {
            Application.OpenForms["Form1"].BringToFront();
            tbDir.Text = defaultpath;
            tbHot.ReadOnly = true;
        }

        private void BtnOpenfolder_Click(object sender, EventArgs e) //Opening saving folder
        {
            System.Diagnostics.Process.Start(defaultpath);
        }

        private void BtnChangefolder_Click(object sender, EventArgs e) //Changigng saving directory
        {
            try
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    defaultpath = folderBrowserDialog.SelectedPath;
                    tbDir.Text = folderBrowserDialog.SelectedPath;
                    MessageBox.Show("Directory changed successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) //When form starts closing there are some options
        {
            if (MessageBox.Show("Do you want to exit the program?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }
        private void CbHotkey_CheckedChanged_1(object sender, EventArgs e) // Checks if hotkey checkbox is checked or not
        {
            cbHotkeyChecking();
            
        }
        private void cbHotkeyChecking() //Method for checking checkbox
        {
            if (cbHotkey.Checked)
            {
                tbHot.ReadOnly = false;
                btnSS.Enabled = false;
                tbHot.Text = "CTRL+F12";
            }
            else
            {
                tbHot.ReadOnly = true;
                tbHot.Clear();
                btnSS.Enabled = true;
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e) //Triggers a hotkey
        {
            if(e.Control && e.KeyCode == Keys.F12)
            {
                ScreenShot();
            }
        }
        private void Form1_Resize(object sender, EventArgs e) //Minimizing to a tray.
        {
            if(WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipTitle = "Notification";
                notifyIcon1.BalloonTipText = "Program is minimized and running in tray.";
                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e) //Going back from a tray
        {
            this.Show();
            WindowState = FormWindowState.Normal;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e) //Toolstrip
        {
            Application.Exit();
        }
    }
}
