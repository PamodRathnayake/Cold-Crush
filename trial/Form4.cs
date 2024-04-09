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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            sidepanel.Height = btnHome.Height;
            sidepanel.Top = btnHome.Top;
            home1.BringToFront();

        }

        private void contact1_Load(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btnHome.Height;
            sidepanel.Top = btnHome.Top;
            home1.BringToFront();


        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btnProduct.Height;
            sidepanel.Top = btnProduct.Top;
            products1.BringToFront();

        }

        private void btnDeliver_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btnDeliver.Height;
            sidepanel.Top = btnDeliver.Top;
            delivery1.BringToFront();

        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btnContact.Height;
            sidepanel.Top = btnContact.Top;
            contact1.BringToFront();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Welcome frm4 = new Welcome();
            frm4.ShowDialog();

        }

        private void btnIce_Click(object sender, EventArgs e)
        {

            sidepanel.Height = btnIce.Height;
            sidepanel.Top = btnIce.Top;
            cart1.BringToFront();
        }
    }
}
