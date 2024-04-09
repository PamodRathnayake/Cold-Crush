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
    public partial class Snacks : UserControl
    {
        public Snacks()
        {
            InitializeComponent();
        }

        private void Burger_Click(object sender, EventArgs e)
        {
            snackRtbx.Text = snackRtbx.Text + "\nHamburger \tRs.500";
        }

        private void HotDog_Click(object sender, EventArgs e)
        {
            snackRtbx.Text = snackRtbx.Text + "\nHotdog \tRs.500";
        }

        private void FrenchFries_Click(object sender, EventArgs e)
        {
            snackRtbx.Text = snackRtbx.Text + "\nFrench Fries \tRs.350";
        }

        private void Sandwich_Click(object sender, EventArgs e)
        {
            snackRtbx.Text = snackRtbx.Text + "\nSandwiches \tRs.350";
        }

        private void MiniPie_Click(object sender, EventArgs e)
        {
            snackRtbx.Text = snackRtbx.Text + "\nMini pies \tRs.350";
        }

        private void MiniPizza_Click(object sender, EventArgs e)
        {
            snackRtbx.Text = snackRtbx.Text + "\nMini Pizza\tRs.350";
        }

        private void brownies_Click(object sender, EventArgs e)
        {
            snackRtbx.Text = snackRtbx.Text + "\nBrownies \tRs.350";
        }

        private void tarts_Click(object sender, EventArgs e)
        {
            snackRtbx.Text = snackRtbx.Text + "\nTarts \tRs.350";
        }

        private void cookie_Click(object sender, EventArgs e)
        {
            snackRtbx.Text = snackRtbx.Text + "\nCookies \tRs.350";
        }

        private void fruitsalad_Click(object sender, EventArgs e)
        {
            snackRtbx.Text = snackRtbx.Text + "\nFruit Salad \tRs.350";
        }

        private void miniCupcake_Click(object sender, EventArgs e)
        {
            snackRtbx.Text = snackRtbx.Text + "\nMini Cupcakes \tRs.350";
        }

        private void btnAddSnack_Click(object sender, EventArgs e)
        {

           // cartA c = new cartA();
            //c.ShowDialog();
        }

        private void Snacks_Load(object sender, EventArgs e)
        {

        }
    }
}
