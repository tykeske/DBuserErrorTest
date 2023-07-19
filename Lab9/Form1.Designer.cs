namespace Lab9
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choice1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choice2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choice3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openNotepadButton = new System.Windows.Forms.Button();
            this.closeNotepadButton = new System.Windows.Forms.Button();
            this.openChromeButton = new System.Windows.Forms.Button();
            this.closeChromeButton = new System.Windows.Forms.Button();
            this.openPowerpointButton = new System.Windows.Forms.Button();
            this.closePowerpointButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.noteProcess = new System.Diagnostics.Process();
            this.chromeProcess = new System.Diagnostics.Process();
            this.powerpointProcess = new System.Diagnostics.Process();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1179, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "&File";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.ToolStripDropDownButton1_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fileToolStripMenuItem.Text = "Login";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.FileToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.ReportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Aqua;
            this.groupBox1.Controls.Add(this.closePowerpointButton);
            this.groupBox1.Controls.Add(this.openPowerpointButton);
            this.groupBox1.Controls.Add(this.closeChromeButton);
            this.groupBox1.Controls.Add(this.openChromeButton);
            this.groupBox1.Controls.Add(this.closeNotepadButton);
            this.groupBox1.Controls.Add(this.openNotepadButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 524);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1179, 88);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose your app";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1_Opening);
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.choice1ToolStripMenuItem,
            this.choice2ToolStripMenuItem,
            this.choice3ToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.backgroundToolStripMenuItem.Text = "background";
            this.backgroundToolStripMenuItem.Click += new System.EventHandler(this.BackgroundToolStripMenuItem_Click);
            // 
            // choice1ToolStripMenuItem
            // 
            this.choice1ToolStripMenuItem.Name = "choice1ToolStripMenuItem";
            this.choice1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.choice1ToolStripMenuItem.Text = "choice 1";
            this.choice1ToolStripMenuItem.Click += new System.EventHandler(this.Choice1ToolStripMenuItem_Click);
            // 
            // choice2ToolStripMenuItem
            // 
            this.choice2ToolStripMenuItem.Name = "choice2ToolStripMenuItem";
            this.choice2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.choice2ToolStripMenuItem.Text = "choice 2";
            this.choice2ToolStripMenuItem.Click += new System.EventHandler(this.Choice2ToolStripMenuItem_Click);
            // 
            // choice3ToolStripMenuItem
            // 
            this.choice3ToolStripMenuItem.Name = "choice3ToolStripMenuItem";
            this.choice3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.choice3ToolStripMenuItem.Text = "choice 3";
            this.choice3ToolStripMenuItem.Click += new System.EventHandler(this.Choice3ToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.ResetToolStripMenuItem_Click);
            // 
            // openNotepadButton
            // 
            this.openNotepadButton.Location = new System.Drawing.Point(57, 31);
            this.openNotepadButton.Name = "openNotepadButton";
            this.openNotepadButton.Size = new System.Drawing.Size(121, 23);
            this.openNotepadButton.TabIndex = 0;
            this.openNotepadButton.Text = "Notepad";
            this.openNotepadButton.UseVisualStyleBackColor = true;
            this.openNotepadButton.Click += new System.EventHandler(this.OpenNotepadButton_Click);
            // 
            // closeNotepadButton
            // 
            this.closeNotepadButton.Location = new System.Drawing.Point(234, 31);
            this.closeNotepadButton.Name = "closeNotepadButton";
            this.closeNotepadButton.Size = new System.Drawing.Size(123, 23);
            this.closeNotepadButton.TabIndex = 1;
            this.closeNotepadButton.Text = "Close Notepad";
            this.closeNotepadButton.UseVisualStyleBackColor = true;
            this.closeNotepadButton.Click += new System.EventHandler(this.CloseNotepadButton_Click);
            // 
            // openChromeButton
            // 
            this.openChromeButton.Location = new System.Drawing.Point(423, 31);
            this.openChromeButton.Name = "openChromeButton";
            this.openChromeButton.Size = new System.Drawing.Size(123, 23);
            this.openChromeButton.TabIndex = 2;
            this.openChromeButton.Text = "Chrome";
            this.openChromeButton.UseVisualStyleBackColor = true;
            this.openChromeButton.Click += new System.EventHandler(this.OpenChromeButton_Click);
            // 
            // closeChromeButton
            // 
            this.closeChromeButton.Location = new System.Drawing.Point(615, 31);
            this.closeChromeButton.Name = "closeChromeButton";
            this.closeChromeButton.Size = new System.Drawing.Size(123, 23);
            this.closeChromeButton.TabIndex = 3;
            this.closeChromeButton.Text = "Close Chrome";
            this.closeChromeButton.UseVisualStyleBackColor = true;
            this.closeChromeButton.Click += new System.EventHandler(this.CloseChromeButton_Click);
            // 
            // openPowerpointButton
            // 
            this.openPowerpointButton.Location = new System.Drawing.Point(805, 31);
            this.openPowerpointButton.Name = "openPowerpointButton";
            this.openPowerpointButton.Size = new System.Drawing.Size(118, 23);
            this.openPowerpointButton.TabIndex = 4;
            this.openPowerpointButton.Text = "Powerpoint";
            this.openPowerpointButton.UseVisualStyleBackColor = true;
            this.openPowerpointButton.Click += new System.EventHandler(this.OpenPowerpointButton_Click);
            // 
            // closePowerpointButton
            // 
            this.closePowerpointButton.Location = new System.Drawing.Point(1001, 31);
            this.closePowerpointButton.Name = "closePowerpointButton";
            this.closePowerpointButton.Size = new System.Drawing.Size(123, 23);
            this.closePowerpointButton.TabIndex = 5;
            this.closePowerpointButton.Text = "Close Powerpoint";
            this.closePowerpointButton.UseVisualStyleBackColor = true;
            this.closePowerpointButton.Click += new System.EventHandler(this.ClosePowerpointButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 602);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1179, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.ToolStripStatusLabel2_Click);
            // 
            // noteProcess
            // 
            this.noteProcess.StartInfo.Domain = "";
            this.noteProcess.StartInfo.FileName = "notepad.exe";
            this.noteProcess.StartInfo.LoadUserProfile = false;
            this.noteProcess.StartInfo.Password = null;
            this.noteProcess.StartInfo.StandardErrorEncoding = null;
            this.noteProcess.StartInfo.StandardOutputEncoding = null;
            this.noteProcess.StartInfo.UserName = "";
            this.noteProcess.SynchronizingObject = this;
            // 
            // chromeProcess
            // 
            this.chromeProcess.StartInfo.Domain = "";
            this.chromeProcess.StartInfo.FileName = "chrome.exe";
            this.chromeProcess.StartInfo.LoadUserProfile = false;
            this.chromeProcess.StartInfo.Password = null;
            this.chromeProcess.StartInfo.StandardErrorEncoding = null;
            this.chromeProcess.StartInfo.StandardOutputEncoding = null;
            this.chromeProcess.StartInfo.UserName = "";
            this.chromeProcess.SynchronizingObject = this;
            // 
            // powerpointProcess
            // 
            this.powerpointProcess.StartInfo.Domain = "";
            this.powerpointProcess.StartInfo.FileName = "powerpoint.exe";
            this.powerpointProcess.StartInfo.LoadUserProfile = false;
            this.powerpointProcess.StartInfo.Password = null;
            this.powerpointProcess.StartInfo.StandardErrorEncoding = null;
            this.powerpointProcess.StartInfo.StandardOutputEncoding = null;
            this.powerpointProcess.StartInfo.UserName = "";
            this.powerpointProcess.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 624);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "MDI Solution";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem choice1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem choice2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem choice3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.Button closePowerpointButton;
        private System.Windows.Forms.Button openPowerpointButton;
        private System.Windows.Forms.Button closeChromeButton;
        private System.Windows.Forms.Button openChromeButton;
        private System.Windows.Forms.Button closeNotepadButton;
        private System.Windows.Forms.Button openNotepadButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Diagnostics.Process noteProcess;
        private System.Diagnostics.Process chromeProcess;
        private System.Diagnostics.Process powerpointProcess;
    }
}

