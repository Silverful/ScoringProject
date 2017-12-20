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
        Form PreviousPageLink;
        CreditListShow sh;
        public CreditList(Form cl)
        {
            InitializeComponent();
            PreviousPageLink = cl;
        }
        public CreditList(Form cl, int count)
        {
            InitializeComponent();
            PreviousPageLink = cl;
            sh = CreditListShow.getInstance();
            sh.SetPageWithCount(richTextBoxCreditInfo, labelCreditName, count);
        }
        public CreditList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            PreviousPageLink.Visible = true;
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
