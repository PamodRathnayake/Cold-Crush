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
   
    public partial class Delivery : UserControl
    {
        public static double total=500;
        public Delivery()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CartsRe_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            textBox2.Text = total.ToString();
            TextReader cartTextd = new StreamReader("C:\\Users\\shazna salman\\Desktop\\Icons\\GUI\\details.txt");
            CartsRe.Text = cartTextd.ReadToEnd();
            cartTextd.Close();

            TextReader cartTextT = new StreamReader("C:\\Users\\shazna salman\\Desktop\\Icons\\GUI\\Total.txt");
            textBox2.Text = cartTextT.ReadToEnd();
            cartTextT.Close();
            /*TextReader cartText = new StreamReader("C:\\Users\\shazna salman\\Desktop\\Icons\\GUI\\Details.txt");
            CartsRe.Text = cartText.ReadToEnd();
            cartText.Close();*/
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Delivery has been made!");
        }

        private void tot_Click(object sender, EventArgs e)
        {

        }
    }
}
