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
            ClientPage cl = new ClientPage();
            cl.Visible = true;
        }

        private void privateData_Click(object sender, EventArgs e)
        {

        }

        private void CheckBoxCheckChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked == true)
            {
                TestCounter.AddToCheckedList(cb);
            }
            else
                TestCounter.DeleteFromCheckedList(cb);
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            if (ContentChecker.CheckGroupBoxedChecked(tabControl1))
            {
                try
                {


                    TestCounter.TotalSum = 0;
                    TestCounter.CountCheckBoxOkay();
                    TestCounter.CountAge(Convert.ToInt32(numericUpDownAge.Value));
                    TestCounter.CountChildren(Convert.ToInt32(numericUpDownChildren.Value));
                    TestCounter.CountSalary(Convert.ToInt32(numericUpDownSalary.Value));

                    TestResultSetter.InitializeSetter(TestCounter.TotalSum, comboBoxCreditType.SelectedItem.ToString(), scoringProject.Logic.Client.getInstance().ID);
                    this.Close();
                    ClientPage cl = new ClientPage();
                    cl.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Проверьте введенные значения!", "Ошибка при выполнени");

                }

            }
            else MessageBox.Show("Проверьте, отметили ли вы все значения", "Ошибки при выполнении");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex++;

        }

        private void checkBoxP1_Click(object sender, EventArgs e)
        {
            ContentChecker.CheckBoxChecker((CheckBox)sender);
        }
    }
}
