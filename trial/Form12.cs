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
    public partial class CusDet : Form
    {
        public CusDet()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome frm4 = new Welcome();
            frm4.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffMain v = new StaffMain();
            v.Show();
        }

        private void btnProUpd_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductUpdate o = new ProductUpdate();
            o.Show();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProdDet p = new ProdDet();
            p.Show();
        }

        private void CusDet_Load(object sender, EventArgs e)
        {

            String con_String = "server=127.0.0.1;user=root;password=;database=trial;";
            MySqlConnection con = new MySqlConnection(con_String);
            String query1 = "select FirstName,LastName,Email from info;";
            MySqlCommand cmd1 = new MySqlCommand(query1, con);
            con.Open();
            MySqlDataReader rdr = cmd1.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(rdr);
            dataGridView2.DataSource = table;
            rdr.Close();
            con.Close();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            StaffContact so = new StaffContact();
            so.Show();
            this.Close();
        }
    }
}
