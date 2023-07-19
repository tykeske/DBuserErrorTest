using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;



namespace Lab9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Form3 f3;
        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection
                (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\loginBase.mdb;Integrated Security=True");

            OleDbConnection LoginConnection;

            LoginConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source = " + Application.StartupPath + "\\loginBase.mdb");

            //Open the database
            LoginConnection.Open();

            progressBar1.Maximum = 100;
            percentLabel.Visible = false;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "")
            {
                MessageBox.Show("User Name Needed");
            }

            if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Password Needed");
            }

            //string connection to access table
            string connection = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = 'loginBase.mdb'";
            string queryString =
                "SELECT userName, password FROM login WHERE (userName) = '" +
                userNameTextBox.Text.ToUpper() + "'";

            try
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(queryString, connection);

                //populate username and password to dataset

                DataSet user = new DataSet();

                adapter.Fill(user, "login");

                //validate the user name

                if (user.Tables["login"].Rows.Count == 0)
                {
                    //if user not found
                    MessageBox.Show("Invalid Username or Password", "Login Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

                //validate password
                foreach (DataRow row in user.Tables["login"].Rows)
                {
                    if (row["password"].ToString() == passwordTextBox.Text)
                    {
                        //sucessful login. Display next form and close login
                        //travelForm travel = new travelForm();
                        this.Hide();
                        //selectedForm.ShowDialog();
                        MessageBox.Show("Found");
                        this.Close();
                        //opens data form
                        f3 = new Form3();
                        f3.MdiParent = Form1.ActiveForm;
                        f3.Show();
                    }

                    else
                    {
                        //failed log in
                        MessageBox.Show("Check user name or password", "Login Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
            catch
            {
                //Something went wrong. display error message.
                MessageBox.Show("Error in accessing the table");
            }
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            timer1.Start();
            percentLabel.Visible = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            percentLabel.Text =
                progressBar1.Value.ToString() + "%";

            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer1.Stop();
                progressBar1.Increment(0);
                passwordTextBox.Enabled = false;
                MessageBox.Show("Out of time!");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //Will close the program but will output a message to confirm exit
            if (MessageBox.Show("Are you sure you want to exit?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }

        private void UserNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                MessageBox.Show("No shortcuts allowed!");
            }
        }

        private void EmailTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                MessageBox.Show("No shortcuts allowed!");
            }
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                MessageBox.Show("No shortcuts allowed!");
            }
        }


    }
}
