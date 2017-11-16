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
            Client cl = Client.getInstance();
            int ID = InteractionDB.CountNextID();
            DateTime DateOfBirth = DateTime.Parse(textBoxDateOfBirth.Text);
            DateTime PassportDate = DateTime.Parse(textBoxPassportDate.Text);
            cl.FillInstance(ID, textBoxLogin.Text, textBoxPassword.Text, textBoxSurname.Text, textBoxName.Text, textBoxPatronymic.Text,
                DateOfBirth, textBoxPlaceOfBirth.Text, textBoxINN.Text, 

            this.Close();
            AuthLink.Visible = true;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex++;
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
