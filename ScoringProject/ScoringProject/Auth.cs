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
using scoringProject.Props;

namespace scoringProject
{
    public partial class Auth : Form
    {
        PropsPage PropsP;
        public Auth()
        {
            InitializeComponent();
            PropsLoader Loader = new PropsLoader();
            Loader.LoadSqlText();
        }

        private void butEnter_Click(object sender, EventArgs e)
        {
            if (Authorize.Enter(textBoxLogin, textBoxPass))
            {
                this.Visible = false;
                ClientPage Cl = new ClientPage(this);
                Cl.Visible = true;
                butEnter.Text = "Вход";
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

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.PasswordChar = '*'; 
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
        }

        private void toolStripButtonProperties_Click(object sender, EventArgs e)
        {
            // this.IsMdiContainer = true;
            this.Enabled = false;
           // toolStripButtonProperties.Enabled = false;
            new PropsPage();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CreditList cr = new CreditList(this, 3);
            cr.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CreditList cr = new CreditList(this, 1);
            cr.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CreditList cr = new CreditList(this, 0);
            cr.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CreditList cr = new CreditList(this, 2);
            cr.Visible = true;
        }
    }
}
