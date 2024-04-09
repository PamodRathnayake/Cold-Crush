using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySqlConnector;

namespace trial
{
    public partial class ProdDet : Form
    {
        public ProdDet()
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

            StaffMain su = new StaffMain();
            su.Show();
            this.Close();
        }

        private void btnProUpd_Click(object sender, EventArgs e)
        {

            ProductUpdate sl = new ProductUpdate();
            sl.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            CusDet ps = new CusDet();
            ps.Show();
            this.Close();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            StaffContact so = new StaffContact();
            so.Show();
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
           // String PrName = txtPrName.Text;
           // String PrCost = txtPrCost.Text;
            //String PrType = cboPrType.Text;
           // int que = Convert.ToInt32(TxtQue.Text);
           // Double total = price * que;


            String con_String = "server=127.0.0.1;user=root;password=;database=products;";
            MySqlConnection con = new MySqlConnection(con_String);
            String query1 = "insert into productdet(PrName,PrCost,PrType) values('" + txtPrName.Text + "', '" + txtPrCost.Text + "', '" + cboPrType.Text + "')";
            MySqlCommand cmd1 = new MySqlCommand(query1, con);
            con.Open();
            cmd1.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Product Details Inserted!");
        }

        private void btnUpdt_Click(object sender, EventArgs e)
        {
           /* String name = TxtName.Text;
            String address = TxtAddress.Text;
            int tp = Convert.ToInt32(TxtMobileNo.Text);
            String uName = TxtUname.Text;
            String Pword = TxtPassword.Text;
            String Position = TxtJob.Text;
            int id = Convert.ToInt32(TxtId.Text);

            String con_String = "server=127.0.0.1;user=root;password=;database=products;";
            MySqlConnection con = new MySqlConnection(con_String);
            String query = "update productdet set PrName='" + txtPrName.Text + "',PrCost='" + txtPrCost.Text + "',PrType='" + cboPrType.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();*/


            String con_String = "server=127.0.0.1;user=root;password=;database=products;";
            MySqlConnection con = new MySqlConnection(con_String);
            String query1 = "select PrName,PrCost,PrType from productdet;";
            MySqlCommand cmd1 = new MySqlCommand(query1, con);
            con.Open();
            MySqlDataReader rdr = cmd1.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(rdr);
            dataGridView3.DataSource = table;
            rdr.Close();
            MessageBox.Show("Product Details Updated!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String con_String = "server=127.0.0.1;user=root;password=;database=products;";
            MySqlConnection con = new MySqlConnection(con_String);
            String query = "Delete from productdet where PrName='" + txtPrName.Text + "' ;";
            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Product Details Deleted!");
        }

        private void ProdDet_Load(object sender, EventArgs e)
        {

        }
    }
}
