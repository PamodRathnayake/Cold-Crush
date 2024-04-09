using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace trial
{
    public partial class cartA : Form
    {

        //FruitJuice fruitJuice;//= null;
       
        public cartA(/*FruitJuice fj*/)
        {
            InitializeComponent();
            //this.fruitJuice=fj;
            

          

        }
        //Milkshake milkshake;
        /*public cartA(Milkshake mk)
        {
            InitializeComponent();
            this.milkshake = mk;
        }*/

        private void cart1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            /*this.Hide();
            Main frm11 = new Main();
            frm11.ShowDialog();*/
        }

        private void cartR_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void cartA_Load(object sender, EventArgs e)
        {
           /* if (fruitJuice != null )
            {
                CartsRe.Text = fruitJuice.fruitJuiceRtbx.Text;
                


            }
            if (milkshake != null)
            {
                CartsRe.Text = milkshake.MilkRtbx.Text;
            }
            // CartsRe.Text = milkshake.MilkRtbx.Text;*/

        }

        private void CartsRe_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {

            TextReader cartText = new StreamReader("C:\\Users\\shazna salman\\Desktop\\Icons\\GUI\\details.txt");
            CartsRe.Text = cartText.ReadToEnd();
            cartText.Close();
        }

        private void CartsRe_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Order has been made!");
        }

        /*  public void SaveFileDialog()
          {
              throw new NotImplementedException(this);
          }*/
    }
}
