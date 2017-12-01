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
    public partial class ClientPage : Form
    {
        private Auth LoginLink;
        private Test TestPg;


        public ClientPage()
        {
            InitializeComponent();
            DataGridViewer.FillDataGrid(this);

        }
        public ClientPage(Auth au)
        {
            InitializeComponent();
            LoginLink = au;
            DataGridViewer.FillDataGrid(this);
        }

        private void butBackToLogin_Click(object sender, EventArgs e)
        {
            Client.DestroyInstance();
            LoginLink.Show();
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Test t = new Test();
            t.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            CreditList cl = new CreditList();
            cl.Visible = true;
        }

        private void ClientPage_Load(object sender, EventArgs e)
        {
            ClientPageOpen.LabelChange(HelloName, labelLogin, labelFIO, labelDateofBirth, labelCity);

        }
    }
}
