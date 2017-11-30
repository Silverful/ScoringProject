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
    public partial class Calculator : Form
    {
        private Auth au;
        public Calculator()
        {
            InitializeComponent();
        }
        public Calculator(Auth au)
        {
            InitializeComponent();
            this.au = au;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            au.Visible = true;
        }
    }
}
