using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trial
{
    public partial class StaffMain : Form
    {
        public StaffMain()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            this.Hide();
            Welcome frm4 = new Welcome();
            frm4.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFruitJ_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductUpdate p = new ProductUpdate();
            p.ShowDialog();
           
        }

        private void home1_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CusDet a = new CusDet();
            a.Show();

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProdDet b = new ProdDet();
            b.Show();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            StaffContact so = new StaffContact();
            so.Show();
            this.Close();
        }
    }
}
