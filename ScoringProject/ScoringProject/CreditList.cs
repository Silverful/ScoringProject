using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using scoringProject.Logic;

namespace scoringProject
{
    public partial class CreditList : Form
    {
        ClientPage ClientLink;
        CreditListShow sh;
        public CreditList(ClientPage cl)
        {
            InitializeComponent();
            ClientLink = cl;
        }
        public CreditList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ClientPage cp = new ClientPage();
            cp.Visible = true;
        }

        private void CreditList_Load(object sender, EventArgs e)
        {
            sh = CreditListShow.getInstance();
            sh.SetPage(richTextBoxCreditInfo, labelCreditName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sh.IncreaseCount();
            sh.SetPage(richTextBoxCreditInfo, labelCreditName);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sh.DecreaseCount();
            sh.SetPage(richTextBoxCreditInfo, labelCreditName);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
