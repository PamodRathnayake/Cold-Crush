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
    public partial class Login : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader mdr;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }

            else
            {
                connection.Open();
                string selectQuery = "SELECT * FROM trial.info WHERE Username = '" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "';";
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
                    Main frm4 = new Main();
                    frm4.ShowDialog();

                }
                else
                {

                    MessageBox.Show("Incorrect Login Information! Try again.");
                }

                connection.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            createAcc new1 = new createAcc();
            new1.Show();
        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
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
