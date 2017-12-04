using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using scoringProject.CalculatorL;

namespace scoringProject
{
    public partial class Calculator : Form
    {
        private Auth au;
        private ICalc CurrentCalc;

        public Calculator()
        {
            InitializeComponent();
            comboBoxCreditName.SelectedIndex = 0;

        }
        public Calculator(Auth au)
        {
            InitializeComponent();
            this.au = au;
            comboBoxCreditName.SelectedIndex = 0;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            au.Visible = true;
        }

        private void comboBoxCreditName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CurrentCalc != null)
                CurrentCalc.Clear();
            CurrentCalc = CalculatorLogic.InitializeCalc(this, groupBox1, comboBoxCreditName.SelectedItem.ToString());
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            CurrentCalc.SetResult();
        }
    }
}
