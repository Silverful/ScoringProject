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
    public partial class Registration : Form
    {
        Auth AuthLink;
        public Registration()
        {
            InitializeComponent();
        }
        public Registration(Auth au)
        {
            InitializeComponent();
            AuthLink = au;
        }

        private void butComplete_Click(object sender, EventArgs e)
        {
            this.Close();
            AuthLink.Visible = true;
        }
    }
}
