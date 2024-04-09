using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace trial
{
    public partial class EmployeeCreate : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
       /* MySqlCommand command;
        MySqlDataReader mdr;*/
        public EmployeeCreate()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.txtEEmail.Text.Contains('@') || !this.txtEEmail.Text.Contains('.'))
            {
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtEPassword.Text != txtCEPassword.Text)
            {
                MessageBox.Show("Password doesn't match!", "Error");
                return;
            }
           
            if (string.IsNullOrEmpty(txtEFName.Text) || string.IsNullOrEmpty(txtELName.Text) || string.IsNullOrEmpty(txtAddress.Text)|| string.IsNullOrEmpty(txtEEmail.Text) || string.IsNullOrEmpty(cboGender.Text) ||string.IsNullOrEmpty(txtNumber.Text) || string.IsNullOrEmpty(txtEUser.Text) || string.IsNullOrEmpty(txtEPassword.Text) || string.IsNullOrEmpty(txtCEPassword.Text))
            {
                MessageBox.Show("Please fill out all information!", "Error");
                return;
            }

            else
            {
                connection.Open();

                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM employee.empInfo WHERE Username = @UserName", connection),
                cmd2 = new MySqlCommand("SELECT * FROM employee.empInfo WHERE Email = @UserEmail", connection);


                cmd1.Parameters.AddWithValue("@UserName", txtEUser.Text);
                cmd2.Parameters.AddWithValue("@UserEmail", txtEEmail.Text);

                bool userExists = false, mailExists = false;

                using (var dr1 = cmd1.ExecuteReader())
                    if (userExists = dr1.HasRows) MessageBox.Show("Username not available!");

                using (var dr2 = cmd2.ExecuteReader())
                    if (mailExists = dr2.HasRows) MessageBox.Show("Email not available!");


                if (!(userExists || mailExists))
                {

                    string iquery = "INSERT INTO employee.empInfo(`firstname`,`lastname`,`address`,`birthday`,`email`,`gender`,`number`,`username`, `password`) VALUES ( '" + txtEFName.Text + "', '" + txtELName.Text + "', '" +txtAddress.Text+ "', '" + dateTimePicker.Value.Date + "', '"+ txtEEmail.Text + "', '" + cboGender.Text+ "', '" + txtNumber.Text+ "', '" + txtEUser.Text + "', '" + txtEPassword.Text + "')";
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

                connection.Close();

                txtEFName.Clear();
                txtELName.Clear();
                txtAddress.Clear();
                txtEEmail.Clear();
                cboGender.SelectedIndex=-1;
                txtNumber.Clear();
                txtEUser.Clear();
                txtEPassword.Clear();
                txtCEPassword.Clear();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeLogin frm3 = new EmployeeLogin();
            frm3.ShowDialog();
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Input numbers only");
            }
        }

        private void txtEFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Input letters only");
            }
        }

        private void txtELName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Input letters only");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeCreate_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome frm4 = new Welcome();
            frm4.ShowDialog();
        }
    }
    }

