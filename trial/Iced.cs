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
    public partial class Iced : UserControl
    {
        public Iced()
        {
            InitializeComponent();
        }

        private void BlackIce_Click(object sender, EventArgs e)
        {
            IceRtbx.Text = IceRtbx.Text + "\nBlack Iced Tea \tRs.200";
        }

        private void PeachIce_Click(object sender, EventArgs e)
        {
            IceRtbx.Text = IceRtbx.Text + "\nPeach Iced Tea \tRs.200";
        }

        private void MintIce_Click(object sender, EventArgs e)
        {
            IceRtbx.Text = IceRtbx.Text + "\nMint Iced Tea \tRs.200";
        }

        private void CoffeeIce_Click(object sender, EventArgs e)
        {
            IceRtbx.Text = IceRtbx.Text + "\nIced Coffee \tRs.200";
        }

        private void Americano_Click(object sender, EventArgs e)
        {
            IceRtbx.Text = IceRtbx.Text + "\nIced Americano \tRs.200";
        }

        private void cherryBloss_Click(object sender, EventArgs e)
        {
            IceRtbx.Text = IceRtbx.Text + "\nIced Cherry Blossom \tRs.200";
        }

        private void KiwiIced_Click(object sender, EventArgs e)
        {
            IceRtbx.Text = IceRtbx.Text + "\nKiwi Iced Tea \tRs.200";
        }

        private void WatermelonJ_Click(object sender, EventArgs e)
        {
            IceRtbx.Text = IceRtbx.Text + "\nIced Mocha \tRs.200";
        }

        private void StrawberryIce_Click(object sender, EventArgs e)
        {
            IceRtbx.Text = IceRtbx.Text + "\nStrawberry Iced Tea \tRs.200";
        }

        private void btnAddIce_Click(object sender, EventArgs e)
        {
           // cartA c = new cartA();
            //c.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Iced_Load(object sender, EventArgs e)
        {

        }
    }
}
