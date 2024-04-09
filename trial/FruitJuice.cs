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
using MySql.Data.MySqlClient;

namespace trial
{
    
    public partial class Products : UserControl
    {
        public static double total=0;
        public Products()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void AppleJ_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nApple Juice\t\tRs.250";
            total = total + 250;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void applePbx_Click(object sender, EventArgs e)
        {
           

            

        }

        private void addBtn1_Click(object sender, EventArgs e)
        {
            
           
           
        }

        private void FruitJuice_Load(object sender, EventArgs e)
        {
           
        }

        public void btnmainCart_Click(object sender, EventArgs e, string text)
        {
        }

        public void btnmainCart_Click(object sender, EventArgs e)
        {
           
        }

        private void AvacadoJ_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nAvacado Juice\t\tRs.200";
            total = total + 200;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
            
        }

        private void fruitJuiceRtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddFruit_Click(object sender, EventArgs e)
        {
            TextWriter textDT = new StreamWriter("C:\\Users\\shazna salman\\Desktop\\Icons\\GUI\\Total.txt");
            textDT.Write(textBox1.Text);
            textDT.Close();

            TextWriter textO = new StreamWriter("C:\\Users\\shazna salman\\Desktop\\Icons\\GUI\\details.txt");
            textO.Write(ProductRtbx.Text);
            textO.Close();

            //cartA c = new cartA(this);
            //c.ShowDialog();
           // c.SaveFileDialog();


            /*string text = fruitJuiceRtbx.Text;*/
            //this.Hide();
            //cartA c = new cartA();
            //c.ShowDialog();
        }

        private void fruitJuiceRtbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void MangoJ_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nMango Juice\t\tRs.250";
            total = total + 250;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
                
        }

        private void PapayaJ_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nPapaya Juice\t\tRs.150";
            total = total + 150;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
        }

        private void Pineapple_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nPineapple Juice\t\tRs.300";
            total = total + 300;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void grape_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nGrape Juice\t\tRs.350";
            total = total + 350;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
        }

        private void LemonJ_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nLemonade\t\tRs.100";
            total = total + 100;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
        }

        private void WatermelonJ_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nWatermelon Juice\tRs.230";
            total = total + 230;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
        }

        private void guava_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nGuava Juice\t\tRs.250";
            total = total + 250;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
        }

        private void Coffee_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nCoffee\t\t\tRs.250";
            total = total + 250;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
        }

        private void Cappacino_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nCappaccino\t\tRs.450";
            total = total + 450;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();

        }

        private void MilkTea_Click(object sender, EventArgs e)
        {

            ProductRtbx.Text = ProductRtbx.Text + "\nMilk Tea\t\t\tRs.200";
            total = total + 200;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
        }

        private void spiceLatte_Click(object sender, EventArgs e)
        {

            ProductRtbx.Text = ProductRtbx.Text + "\nSpice Latte\t\tRs.350";
            total = total + 350;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();

        }

        private void BlackTea_Click(object sender, EventArgs e)
        {

            ProductRtbx.Text = ProductRtbx.Text + "\nBlack Tea\t\tRs.150";
            total = total + 150;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();

        }

        private void ChaiLatte_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nChai Latte\t\tRs.300";
            total = total + 300;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();

        }

        private void WhiteHot_Click(object sender, EventArgs e)
        {

            ProductRtbx.Text = ProductRtbx.Text + "\nWhite Hot Chocolate\tRs.430";
            total = total + 430;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();

        }

        private void HotChocol_Click(object sender, EventArgs e)
        {
           
            ProductRtbx.Text = ProductRtbx.Text + "\nHot Chocolate\t\tRs.400";
            total = total + 400;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();

        }

        private void GreenTea_Click(object sender, EventArgs e)
        {

            ProductRtbx.Text = ProductRtbx.Text + "\nGreen Tea\t\tRs.130";
            total = total + 130;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
        }

        private void strawberryMilk_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nStrawberry Milkshake\tRs.400";
            total = total + 400;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();

        }

        private void ChocMilk_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nChocolate Milkshake\tRs.400";
            total = total + 400;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
        }

        private void BlueMilk_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nBlueberry Milkshake\tRs.450";
            total = total + 450;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
        }

        private void BananaMilk_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nBanana Milkshake\tRs.350";
            total = total + 350;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
        }

        private void Mangoilk_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nMango Milkshake\t\tRs.400";
            total = total + 400;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
        }

        private void OreoMilk_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nOreo Milkshake\t\tRs.500";
            total = total + 500;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
        }

        private void VanillaMilk_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nVanilla Milkshake\t\tRs.400";
            total = total + 400;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
        }

        private void ShamMilk_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nShamrock Milkshake\tRs.500";
            total = total + 500;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
        }

        private void RaspMilk_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nRaspberry Milkshake\tRs.500";
            total = total + 500;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
        }

        private void BlackIce_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nBlack Iced Tea\t\tRs.150";
            total = total + 150;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
        }

        private void PeachIce_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nPeach Iced Tea\t\tRs.200";
            total = total + 200;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
        }

        private void MintIce_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nMint Iced Tea\t\tRs.150";
            total = total + 150;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
        }

        private void CoffeeIce_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nIced Coffee\t\tRs.350";
            total = total + 350;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nIced Americano\t\tRs.450";
            total = total + 450;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
        }

        private void cherryBloss_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nCherry Blossom\t\tRs.500";
            total = total + 500;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
        }

        private void StrawberryIce_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nStrawberry Iced Tea\tRs.200";
            total = total + 200;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nIced Mocha\t\tRs.350";
            total = total + 350;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
        }

        private void KiwiIced_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nKiwi Iced Tea\t\tRs.500";
            total = total + 500;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
        }

        private void Burger_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nHamburger\t\tRs.500";
            total = total + 500;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
        }

        private void HotDog_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nHotdog\t\t\tRs.500";
            total = total + 500;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
        }

        private void FrenchFries_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nFrench Fries\t\tRs.250";
            total = total + 250;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
        }

        private void MiniPizza_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nMini Pizza\t\tRs.450";
            total = total + 450;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
        }

        private void fruitsalad_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nFruit Salad\t\tRs.400";
            total = total + 400;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
        }

        private void tarts_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nTarts\t\t\tRs.300";
            total = total + 300;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
        }

        private void cookie_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nCookies\t\t\tRs.300";
            total = total + 300;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
        }

        private void miniCupcake_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nMini Cupcakes\t\tRs.300";
            total = total + 300;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();

        }

        private void brownies_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nBrownies\t\tRs.450";
            total = total + 450;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void MiniPie_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nMini Pies\t\tRs.420";
            total = total + 420;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
        }

        private void Sandwich_Click(object sender, EventArgs e)
        {
            ProductRtbx.Text = ProductRtbx.Text + "\nSandwiches\t\tRs.300";
            total = total + 300;
            tot.Text = total.ToString();
            textBox1.Text = total.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            total = 0;

            ProductRtbx.Text = "";
            tot.Text = "0.00";
            textBox1.Text = "0.00";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            TextWriter textD = new StreamWriter("C:\\Users\\shazna salman\\Desktop\\Icons\\GUI\\Details.txt");
            textD.Write(ProductRtbx.Text);
            textD.Close();

            TextWriter textDT= new StreamWriter("C:\\Users\\shazna salman\\Desktop\\Icons\\GUI\\Total.txt");
            textDT.Write(textBox1.Text);
            textDT.Close();
        }

        private void tot_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
