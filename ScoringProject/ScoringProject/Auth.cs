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
    public partial class Auth : Form
    {
        private ClientPage ClientPg;
        public Auth()
        {
            InitializeComponent();
            
            ClientPg = new ClientPage(this);
        }

        private void butEnter_Click(object sender, EventArgs e)
        {
            if (Authorize.Enter(textBoxLogin, textBoxPass))
            {
                this.Visible = false;
                if (ClientPg.IsDisposed == false)
                    ClientPg.Visible = true;
                else
                {
                    ClientPage Cl = new ClientPage(this);
                    Cl.Visible = true;
                }
            }
            else butEnter.Text = "Вход не удался";


        }

        private void butReg_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Registration Regist = new Registration(this);
            Regist.Visible = true;
        }

        private void buttonCalculator_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Calculator cal = new Calculator(this);
            cal.Visible = true;

        }
    }
}
