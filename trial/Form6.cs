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
    public partial class EmployeeLogin : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader mdr;
        public EmployeeLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEUsername.Text) || string.IsNullOrEmpty(txtEPassword.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }

            else
            {
                connection.Open();
                string selectQuery = "SELECT * FROM employee.empInfo WHERE Username = '" + txtEUsername.Text + "' AND Password = '" + txtEPassword.Text + "';";
                command = new MySqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    /* string MyConnection2 = "datasource=localhost;port=3306;username=root;password=";
                     string Query = "update trial.info set Username='" + this.txtUsername.Text + "';";
                     MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                     MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                     MySqlDataReader MyReader2;
                     MyConn2.Open();
                     MyReader2 = MyCommand2.ExecuteReader();
                     while (MyReader2.Read())
                     {
                     }
                     MyConn2.Close();*/

                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    StaffMain frm4 = new StaffMain();
                    frm4.ShowDialog();

                }
                else
                {

                    MessageBox.Show("Incorrect Login Information! Try again.");
                }

                connection.Close();
            }
        }

        private void btnEmCreate_Click(object sender, EventArgs e)
        {

            this.Hide();
            EmployeeCreate frm5 = new EmployeeCreate();
            frm5.ShowDialog();
        }

        private void EmployeeLogin_Load(object sender, EventArgs e)
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
