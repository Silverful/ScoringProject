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
    public partial class Auth : Form
    {
        private ClientPage ClientPg;
        public Auth()
        {
            InitializeComponent();
            
            ClientPg = new ClientPage(this);
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {


        }

        private void simpleButton2_Click(object sender, EventArgs e)
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
        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            Registration Regist = new Registration(this);
            Regist.Visible = true;
        }
    }
}
