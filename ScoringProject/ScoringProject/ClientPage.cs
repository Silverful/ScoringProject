using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scoringProject
{
    public partial class ClientPage : Form
    {
        private Auth LoginLink;
        private Test TestPg;


        public ClientPage()
        {
            InitializeComponent();
        }
        public ClientPage(Auth au)
        {
            InitializeComponent();
            LoginLink = au;
        }

        private void butBackToLogin_Click(object sender, EventArgs e)
        {
            LoginLink.Show();
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TestPg = new Test(this);
            TestPg.Visible = true;
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreditList Cr = new CreditList(this);
            this.Visible = false;
            Cr.Visible = true;
        }
    }
}
