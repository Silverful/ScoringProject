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
    public partial class CreditList : Form
    {
        ClientPage ClientLink;
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
            ClientLink.Visible = true;
        }
    }
}
