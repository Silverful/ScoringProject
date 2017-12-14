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
        string Family;
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
            try
            {
                Client cl = Client.getInstance();
                int ID = InteractionDB.CountNextID();
                DateTime DateOfBirth = DateTime.Parse(textBoxDateOfBirth.Text);
                DateTime PassportDate = DateTime.Parse(textBoxPassportDate.Text);
                string gender;
                if (checkBoxFemale.Checked == true)
                    gender = "женский";
                else gender = "мужской";
                string education = null;
                foreach (object item in checkedListBoxEducation.SelectedItems)
                {
                    education += item.ToString();
                    education += "/";
                }
                switch (checkedListBoxFamily.SelectedIndex)
                {
                    case 0:
                        Family = "Женат/Замужем";

                        break;
                    case 1:
                        Family = "Холост/Не замужем";
                        break;
                    case 2:
                        Family = "Гражданский брак";
                        break;
                    case 3:
                        Family = "Разведен/Разведена";
                        break;
                    case 4:
                        Family = "Вдова/Вдовец";
                        break;

                }
                cl.CreateSQLQuery(textBoxLogin.Text, textBoxPassword.Text, textBoxSurname.Text, textBoxName.Text, textBoxPatronymic.Text,
                    DateOfBirth, textBoxPlaceOfBirth.Text, textBoxINN.Text, gender, textBoxPassportSeries.Text, textBoxPassportNumber.Text,
                    PassportDate, textBoxPassportCode.Text, textBoxPassportPlace.Text, textBoxPhoneNumber.Text, textBoxHomeNumber.Text,
                    textBoxEmail.Text, education, Family, textBoxAdressIndex.Text, textBoxAdressRegion.Text, textBoxAdressArea.Text, textBoxAdressCity.Text);
                InteractionDB.AddClient(cl);
                this.Close();
                AuthLink.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте вводимые значения!", "Ошибка при выполнении");
            }


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

        private void textBoxNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            ContentChecker.CheckNumTextBox(sender, e);
        }

        private void textBoxLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            ContentChecker.CheckTextBox(sender, e);
        }
    }
}
