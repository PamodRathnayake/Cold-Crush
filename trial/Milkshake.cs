using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trial
{
    public partial class Milkshake : UserControl
    {
        public Milkshake()
        {
            InitializeComponent();
        }

        private void strawberryMilk_Click(object sender, EventArgs e)
        {
            MilkRtbx.Text = MilkRtbx.Text + "\nStrawberry Milkshake \tRs.250";
        }

        private void ChocMilk_Click(object sender, EventArgs e)
        {
            MilkRtbx.Text = MilkRtbx.Text + "\nChocolate Milkshake \tRs.250";
        }

        private void BlueMilk_Click(object sender, EventArgs e)
        {
            MilkRtbx.Text = MilkRtbx.Text + "\nBlueberry Milkshake \tRs.250";
        }

        private void BananaMilk_Click(object sender, EventArgs e)
        {
            MilkRtbx.Text = MilkRtbx.Text + "\nBanana Milkshake \tRs.250";
        }

        private void Mangoilk_Click(object sender, EventArgs e)
        {
            MilkRtbx.Text = MilkRtbx.Text + "\nMango Milkshake \tRs.250";
        }

        private void OreoMilk_Click(object sender, EventArgs e)
        {
            MilkRtbx.Text = MilkRtbx.Text + "\nOreo Milkshake \tRs.250";
        }

        private void VanillaMilk_Click(object sender, EventArgs e)
        {
            MilkRtbx.Text = MilkRtbx.Text + "\nVanilla Milkshake \tRs.250";
        }

        private void ShamMilk_Click(object sender, EventArgs e)
        {
            MilkRtbx.Text = MilkRtbx.Text + "\nShamrock Milkshake \tRs.250";
        }

        private void RaspMilk_Click(object sender, EventArgs e)
        {
            MilkRtbx.Text = MilkRtbx.Text + "\nRaspberry Milkshake \tRs.250";
        }

        private void btnAddMilk_Click(object sender, EventArgs e)
        {
            TextWriter textM = new StreamWriter("C:\\Users\\shazna salman\\Desktop\\Icons\\GUI\\details.txt");
            textM.Write(MilkRtbx.Text);
            textM.Close();

            //cartA c= new cartA(this);
            //c.ShowDialog();
        }

        private void MilkRtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void Milkshake_Load(object sender, EventArgs e)
        {

        }
    }
}
