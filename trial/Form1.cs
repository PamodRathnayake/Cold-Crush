using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace trial
{
    public partial class Welcome : Form
    {
        
        public Welcome()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm1 = new Login();
            frm1.ShowDialog();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeLogin frm6 = new EmployeeLogin();
            frm6.ShowDialog();

        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }
    }
}
