namespace Lab9
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.searchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.loginDataGridView = new System.Windows.Forms.DataGridView();
            this.fillByNameToolStrip = new System.Windows.Forms.ToolStrip();
            this.firstNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.firstNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.lastNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.lastNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.passwordToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.passwordToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.emailAddressToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.emailAddressToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.userNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.userNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByNameToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginBaseDataSet = new Lab9.loginBaseDataSet();
            this.loginTableAdapter = new Lab9.loginBaseDataSetTableAdapters.loginTableAdapter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataGridView)).BeginInit();
            this.fillByNameToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchTextBox,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripSeparator3,
            this.toolStripButton4,
            this.toolStripSeparator4,
            this.toolStripButton5,
            this.toolStripSeparator5,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 25);
            this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchTextBox_KeyPress);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton1.Text = "Search";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(102, 22);
            this.toolStripButton2.Text = "Show All Records";
            this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(59, 22);
            this.toolStripButton3.Text = "Move Up";
            this.toolStripButton3.Click += new System.EventHandler(this.ToolStripButton3_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(75, 22);
            this.toolStripButton4.Text = "Move Down";
            this.toolStripButton4.Click += new System.EventHandler(this.ToolStripButton4_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton5.Text = "First Record";
            this.toolStripButton5.Click += new System.EventHandler(this.ToolStripButton5_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(72, 22);
            this.toolStripButton6.Text = "Last Record";
            this.toolStripButton6.Click += new System.EventHandler(this.ToolStripButton6_Click);
            // 
            // loginDataGridView
            // 
            this.loginDataGridView.AutoGenerateColumns = false;
            this.loginDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loginDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn});
            this.loginDataGridView.DataSource = this.loginBindingSource;
            this.loginDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginDataGridView.Location = new System.Drawing.Point(0, 25);
            this.loginDataGridView.Name = "loginDataGridView";
            this.loginDataGridView.Size = new System.Drawing.Size(800, 425);
            this.loginDataGridView.TabIndex = 1;
            // 
            // fillByNameToolStrip
            // 
            this.fillByNameToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstNameToolStripLabel,
            this.firstNameToolStripTextBox,
            this.lastNameToolStripLabel,
            this.lastNameToolStripTextBox,
            this.passwordToolStripLabel,
            this.passwordToolStripTextBox,
            this.emailAddressToolStripLabel,
            this.emailAddressToolStripTextBox,
            this.userNameToolStripLabel,
            this.userNameToolStripTextBox,
            this.fillByNameToolStripButton});
            this.fillByNameToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillByNameToolStrip.Name = "fillByNameToolStrip";
            this.fillByNameToolStrip.Size = new System.Drawing.Size(800, 25);
            this.fillByNameToolStrip.TabIndex = 2;
            this.fillByNameToolStrip.Text = "fillByNameToolStrip";
            this.fillByNameToolStrip.Visible = false;
            this.fillByNameToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.FillByNameToolStrip_ItemClicked);
            // 
            // firstNameToolStripLabel
            // 
            this.firstNameToolStripLabel.Name = "firstNameToolStripLabel";
            this.firstNameToolStripLabel.Size = new System.Drawing.Size(62, 22);
            this.firstNameToolStripLabel.Text = "firstName:";
            // 
            // firstNameToolStripTextBox
            // 
            this.firstNameToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.firstNameToolStripTextBox.Name = "firstNameToolStripTextBox";
            this.firstNameToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // lastNameToolStripLabel
            // 
            this.lastNameToolStripLabel.Name = "lastNameToolStripLabel";
            this.lastNameToolStripLabel.Size = new System.Drawing.Size(60, 22);
            this.lastNameToolStripLabel.Text = "lastName:";
            // 
            // lastNameToolStripTextBox
            // 
            this.lastNameToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lastNameToolStripTextBox.Name = "lastNameToolStripTextBox";
            this.lastNameToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // passwordToolStripLabel
            // 
            this.passwordToolStripLabel.Name = "passwordToolStripLabel";
            this.passwordToolStripLabel.Size = new System.Drawing.Size(60, 22);
            this.passwordToolStripLabel.Text = "password:";
            // 
            // passwordToolStripTextBox
            // 
            this.passwordToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordToolStripTextBox.Name = "passwordToolStripTextBox";
            this.passwordToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // emailAddressToolStripLabel
            // 
            this.emailAddressToolStripLabel.Name = "emailAddressToolStripLabel";
            this.emailAddressToolStripLabel.Size = new System.Drawing.Size(81, 22);
            this.emailAddressToolStripLabel.Text = "emailAddress:";
            // 
            // emailAddressToolStripTextBox
            // 
            this.emailAddressToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailAddressToolStripTextBox.Name = "emailAddressToolStripTextBox";
            this.emailAddressToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // userNameToolStripLabel
            // 
            this.userNameToolStripLabel.Name = "userNameToolStripLabel";
            this.userNameToolStripLabel.Size = new System.Drawing.Size(64, 22);
            this.userNameToolStripLabel.Text = "userName:";
            // 
            // userNameToolStripTextBox
            // 
            this.userNameToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userNameToolStripTextBox.Name = "userNameToolStripTextBox";
            this.userNameToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // fillByNameToolStripButton
            // 
            this.fillByNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByNameToolStripButton.Name = "fillByNameToolStripButton";
            this.fillByNameToolStripButton.Size = new System.Drawing.Size(71, 19);
            this.fillByNameToolStripButton.Text = "FillByName";
            this.fillByNameToolStripButton.Click += new System.EventHandler(this.FillByNameToolStripButton_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "firstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "lastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "emailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "emailAddress";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "userName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "userName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "login";
            this.loginBindingSource.DataSource = this.loginBaseDataSet;
            // 
            // loginBaseDataSet
            // 
            this.loginBaseDataSet.DataSetName = "loginBaseDataSet";
            this.loginBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fillByNameToolStrip);
            this.Controls.Add(this.loginDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form3";
            this.Text = "Data Form";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataGridView)).EndInit();
            this.fillByNameToolStrip.ResumeLayout(false);
            this.fillByNameToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox searchTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.DataGridView loginDataGridView;
        private loginBaseDataSet loginBaseDataSet;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private loginBaseDataSetTableAdapters.loginTableAdapter loginTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByNameToolStrip;
        private System.Windows.Forms.ToolStripLabel firstNameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox firstNameToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel lastNameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox lastNameToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel passwordToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox passwordToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel emailAddressToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox emailAddressToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel userNameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox userNameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByNameToolStripButton;
    }
}