using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Data.SqlClient;

namespace Lab9
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginBaseDataSet.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.loginBaseDataSet.login);
            

        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {

            try
            {
                this.loginTableAdapter.FillByName(this.loginBaseDataSet.login, searchTextBox.Text, searchTextBox.Text, searchTextBox.Text, searchTextBox.Text, searchTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void SearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void FillByNameToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.loginTableAdapter.FillByName(this.loginBaseDataSet.login, firstNameToolStripTextBox.Text, lastNameToolStripTextBox.Text, passwordToolStripTextBox.Text, emailAddressToolStripTextBox.Text, userNameToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void FillByNameToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            this.loginTableAdapter.Fill(this.loginBaseDataSet.login);
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            if (loginDataGridView.Rows.Count >= 1)
            {
                int i = loginDataGridView.CurrentRow.Index - 1;
                if (i >= 1 && i < loginDataGridView.Rows.Count)
                {
                    loginDataGridView.CurrentCell = loginDataGridView.Rows[i].Cells[0];
                }
            }
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            if (loginDataGridView.Rows.Count >= 1)
            {
                int i = loginDataGridView.CurrentRow.Index + 1;
                if (i >= -1 && i < loginDataGridView.Rows.Count)
                {
                    loginDataGridView.CurrentCell = loginDataGridView.Rows[i].Cells[0];
                }
            }
        }

        private void ToolStripButton5_Click(object sender, EventArgs e)
        {
            loginDataGridView.Rows.OfType<DataGridViewRow>().Last().Selected = false;
            loginDataGridView.Rows.OfType<DataGridViewRow>().First().Selected = true;
        }

        private void ToolStripButton6_Click(object sender, EventArgs e)
        {
            loginDataGridView.Rows.OfType<DataGridViewRow>().First().Selected = false;
            loginDataGridView.Rows.OfType<DataGridViewRow>().Last().Selected = true;
        }
    }
}
