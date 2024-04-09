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
    public partial class Hot : UserControl
    {
        public Hot()
        {
            InitializeComponent();
        }

        private void btnAddHot_Click(object sender, EventArgs e)
        {

            //cartA c = new cartA();
            //c.ShowDialog();
        }

        private void Coffee_Click(object sender, EventArgs e)
        {
            HotRtbx.Text = HotRtbx.Text + "\nCoffee \tRs.350";
        }

        private void MilkTea_Click(object sender, EventArgs e)
        {
            HotRtbx.Text = HotRtbx.Text + "\nMilk Tea \tRs.350";
        }

        private void Cappacino_Click(object sender, EventArgs e)
        {
            HotRtbx.Text = HotRtbx.Text + "\nCappaccino \tRs.350";
        }

        private void BlackTea_Click(object sender, EventArgs e)
        {
            HotRtbx.Text = HotRtbx.Text + "\nBlack Tea\tRs.350";
        }

        private void spiceLatte_Click(object sender, EventArgs e)
        {
            HotRtbx.Text = HotRtbx.Text + "\nSpice Latte \tRs.350";
        }

        private void ChaiLatte_Click(object sender, EventArgs e)
        {
            HotRtbx.Text = HotRtbx.Text + "\nChai Latte \tRs.350";
        }

        private void WhiteHot_Click(object sender, EventArgs e)
        {
            HotRtbx.Text = HotRtbx.Text + "\nWhite Hot Chocolate \tRs.350";
        }

        private void GreenTea_Click(object sender, EventArgs e)
        {
            HotRtbx.Text = HotRtbx.Text + "\nGreen Tea \tRs.350";
        }

        private void HotChocol_Click(object sender, EventArgs e)
        {
            HotRtbx.Text = HotRtbx.Text + "\nHot Chocolate \tRs.350";
        }

        private void Hot_Load(object sender, EventArgs e)
        {

        }
    }
}
