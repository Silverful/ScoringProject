using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace scoringProject.Logic
{
    public static class TestCounter
    {
        public static int TotalSum = 0;
        public static List<CheckBox> CheckedBox = new List<CheckBox>();
        #region Подсчет CheckBoxes
        public static void AddToCheckedList(CheckBox CB)
        {
            CheckedBox.Add(CB);
        }
        public static void DeleteFromCheckedList(CheckBox CB)
        {
            CheckedBox.Remove(CB);
        }
        public static void CountCheckBoxOkay()
        {
            foreach (var cb in CheckedBox)
            {
                TotalSum += Convert.ToInt32(cb.Tag);
            }
        }
        #endregion
        #region Подсчет NumericUpDown
        public static void CountAge(int num)
        {
            if (num < 20 || num >= 60)
                TotalSum += 15;
            else if (num >= 20 && num < 25)
                TotalSum += 34;
            else if (num >= 25 && num < 30)
                TotalSum += 50;
            else if (num >= 30 && num < 50)
                TotalSum += 114;
            else if (num >= 50 && num < 60)
                TotalSum += 97;

        }
        public static void CountSalary(int sal)
        {
            if (sal < 5000)
                TotalSum += 9;
            else if (sal >= 5000 && sal < 15000)
                TotalSum += 57;
            else if (sal >= 15000 && sal < 25000)
                TotalSum += 94;
            else if (sal >= 25000 && sal < 40000)
                TotalSum += 140;
            else if (sal >= 40000)
                TotalSum += 198;
        }
        public static void CountChildren(int chil)
        {
            if (chil == 0)
                TotalSum += 87;
            else if (chil == 1)
                TotalSum += 64;
            else if (chil == 2)
                TotalSum += 52;
            else if (chil == 3)
                TotalSum += 14;
            else if (chil > 3)
                TotalSum += 4;
        }
        #endregion
    }
}
