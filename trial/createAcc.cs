using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace trial
{
    

    public partial class createAcc : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");

        public createAcc()
        {
            InitializeComponent();
        }

        private void btnCreated_Click(object sender, EventArgs e)
        {
            if (!this.txtEmail.Text.Contains('@') || !this.txtEmail.Text.Contains('.'))
            {
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPassword.Text != txtCPassword.Text)
            {
                MessageBox.Show("Password doesn't match!", "Error");
                return;
            }

            if (string.IsNullOrEmpty(txtFName.Text) || string.IsNullOrEmpty(txtLName.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtUName.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtCPassword.Text))
            {
                MessageBox.Show("Please fill out all information!", "Error");
                return;
            }

            else
            {
                connection.Open();

                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM trial.info WHERE Username = @UserName", connection),
                cmd2 = new MySqlCommand("SELECT * FROM trial.info WHERE Email = @UserEmail", connection);


                cmd1.Parameters.AddWithValue("@UserName", txtUName.Text);
                cmd2.Parameters.AddWithValue("@UserEmail", txtEmail.Text);

                bool userExists = false, mailExists = false;

                using (var dr1 = cmd1.ExecuteReader())
                    if (userExists = dr1.HasRows) MessageBox.Show("Username not available!");

                using (var dr2 = cmd2.ExecuteReader())
                    if (mailExists = dr2.HasRows) MessageBox.Show("Email not available!");


                if (!(userExists || mailExists))
                {

                    string iquery = "INSERT INTO trial.info(`FirstName`,`LastName`,`Email`,`Username`, `Password`) VALUES ( '" + txtFName.Text + "', '" + txtLName.Text + "', '" + txtEmail.Text + "', '" + txtUName.Text + "', '" + txtPassword.Text + "')";
                    MySqlCommand commandDatabase = new MySqlCommand(iquery, connection);
                    commandDatabase.CommandTimeout = 60;

                    try
                    {
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    }
                    catch (Exception ex)
                    {
                        // Show any error message.
                        MessageBox.Show(ex.Message);
                    }

                    MessageBox.Show("Account Successfully Created!");


                }
            }



            connection.Close();

            txtFName.Clear();
            txtLName.Clear();
            txtEmail.Clear();
            txtUName.Clear();
            txtPassword.Clear();
            txtCPassword.Clear();


        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.Hide();
            Login frm3 = new Login();
            frm3.ShowDialog();
        }

        private void createAcc_Load(object sender, EventArgs e)
        {

        }

        private void txtFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Input letters only");
            }
        }

        private void txtLName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Input letters only");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome frm4 = new Welcome();
            frm4.ShowDialog();
        }
    }
}
