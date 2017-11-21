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
    public partial class Test : Form
    {
        ClientPage Client;
        public Test()
        {
            InitializeComponent();
        }
        public Test(ClientPage ClientPg)
        {
            InitializeComponent();
            Client = ClientPg;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Client.Visible = true;
        }
    }
}
