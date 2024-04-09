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
    public partial class StaffContact : Form
    {
        public StaffContact()
        {
            InitializeComponent();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                Welcome frm4 = new Welcome();
                frm4.ShowDialog();
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProdDet p = new ProdDet();
            p.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CusDet so = new CusDet();
            so.Show();
            this.Close();
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

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.whatsapp.com/");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.twitter.com/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.telegram.com/");
        }

        private void StaffContact_Load(object sender, EventArgs e)
        {

        }
    }
}
