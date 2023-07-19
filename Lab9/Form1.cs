using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form4 f4;
        Form2 f2;
        private void Form1_Load(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.background1;
            toolStripStatusLabel2.Text = DateTime.Now.ToString();
            toolStripStatusLabel1.Text = "Status";
        }

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f4 = new Form4();
            f4.MdiParent = this;
            f4.Show();
        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2 = new Form2();
            f2.MdiParent = this;
            f2.Show();
        }

        private void ToolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void BackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Choice1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.background2;
        }

        private void Choice2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.background3;
        }

        private void Choice3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.background5;
        }

        private void ResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.background1;
        }

        private void OpenNotepadButton_Click(object sender, EventArgs e)
        {
            noteProcess.EnableRaisingEvents = true;
            noteProcess.Start();
            toolStripStatusLabel1.Text = "Notepad is running";
        }

        private void OpenChromeButton_Click(object sender, EventArgs e)
        {
            chromeProcess.EnableRaisingEvents = true;
            chromeProcess.Start();
            toolStripStatusLabel1.Text = "Chrome is running";
        }

        private void OpenPowerpointButton_Click(object sender, EventArgs e)
        {
            powerpointProcess.EnableRaisingEvents = true;
            powerpointProcess.Start();
            toolStripStatusLabel1.Text = "Powerpoint is running";
        }

        private void ToolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            
        }

        private void CloseNotepadButton_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Status";
            noteProcess.Kill();
        }

        private void CloseChromeButton_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Status";
            chromeProcess.Kill();
        }

        private void ClosePowerpointButton_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Status";
            powerpointProcess.Kill();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Will close the program but will output a message to confirm exit
            if (MessageBox.Show("Are you sure you want to exit?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
                this.Close();
            }
        }

        private void BackPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
