using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace trial
{
    public partial class ProductUpdate : Form
    {
        public ProductUpdate()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome frm4 = new Welcome();
            frm4.ShowDialog();
        }

        private void ProductUpdate_Load(object sender, EventArgs e)
        {

            String con_String = "server=127.0.0.1;user=root;password=;database=employee;";
            MySqlConnection con = new MySqlConnection(con_String);
            String query1 = "select firstname,lastname,address,birthday,number from empinfo;";
            MySqlCommand cmd1 = new MySqlCommand(query1, con);
            con.Open();
            MySqlDataReader rdr = cmd1.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(rdr);
            dataGridView1.DataSource = table;
            rdr.Close();
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            StaffMain s = new StaffMain();
            s.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            CusDet so= new CusDet();
            so.Show();
            this.Close();


        }

        private void btnDetails_Click(object sender, EventArgs e)
        {

            ProdDet sp = new ProdDet();
            sp.Show();
            this.Close();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            StaffContact so = new StaffContact();
            so.Show();
            this.Close();
        }
    }
}
