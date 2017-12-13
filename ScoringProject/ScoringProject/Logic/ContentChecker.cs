using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scoringProject.Logic
{
    public static class ContentChecker
    {
        public static void CheckTextBox(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }
        public static void CheckNumTextBox(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                return;
            else e.Handled = true;
        }
        public static void CheckDateBox()
        {

        }
        public static void CheckBoxChecker(CheckBox cb)
        {
            Control ParentGroup = cb.Parent;
            GroupBox GroupB = (GroupBox)ParentGroup;
            int IsChecked = 0;
            foreach (Control c in GroupB.Controls)
            {
                CheckBox CB = (CheckBox)c;
                if (CB.Checked == true)
                {
                    IsChecked++;
                }
            }
            if (IsChecked > 1)
            {
                cb.Checked = false;
                MessageBox.Show("В каждом разделе можно отметить лишь один вариант ответа!");
            }
        }
    }
}
