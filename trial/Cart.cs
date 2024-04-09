using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Net;

namespace trial
{
    public partial class cart : UserControl
    {
        //public static double total;
        public cart()
        {
            InitializeComponent();
          
            
        }


        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        public void cartR_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void pic_Click(object sender, EventArgs e)
        {
            
        }

        public void btnshow_Click(object sender, EventArgs e)
        {
            
        }

        private void Cart1_Load(object sender, EventArgs e)
        {

        }
        String abc;
        private void btnLoad_Click(object sender, EventArgs e)
        {
            //tot.Text = total.ToString();

            TextReader cartText = new StreamReader("C:\\Users\\shazna salman\\Desktop\\Icons\\GUI\\details.txt");
            CartsRe.Text = cartText.ReadToEnd();


            abc = CartsRe.Text;


            cartText.Close();
            TextReader cartTextT = new StreamReader("C:\\Users\\shazna salman\\Desktop\\Icons\\GUI\\Total.txt");
            textBox2.Text = cartTextT.ReadToEnd();
            cartTextT.Close();

            
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
           /* string fromMail = "shaznasalman10@gmail.com";
            string email = "ColdCrushMails@gmail.com";
            using (MailMessage message = new MailMessage())
            {
                message.From = new MailAddress(fromMail);
                message.Subject = "Test Subject";
                message.To.Add(email);
                message.Body = abc;
                message.IsBodyHtml = true;

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
                {
                    smtp.Credentials = new System.Net.NetworkCredential(fromMail, "cenyvbzjdrvypsuw");
                smtp.EnableSsl = true;
                smtp.Send(message);
            }
            }*/

           // MessageBox.Show("email sent");
            MessageBox.Show("Your Order has been made!");
        }

        private void tot_Click(object sender, EventArgs e)
        {
            
        }
    }
}
