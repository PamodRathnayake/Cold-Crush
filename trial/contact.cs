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
    public partial class contact : UserControl
    {
        public contact()
        {
            InitializeComponent();
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
    }
}
