using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scoringProject.Logic
{
    /// <summary>
    /// Класс для обеспечения работа страницы кредитов
    /// </summary>
    public class CreditListShow
    {
        private CreditListShow()
        {
            this.SetUpMaxCount();
        }

        // Реализация синглтона
        private static CreditListShow instance = null;
        public static CreditListShow getInstance()
        {
            if (instance == null)
            {
                instance = new CreditListShow();
                
            }
            return instance;
        }
        /// <summary>
        /// Номер текущего кредита
        /// </summary>
        private int count = 0;
        /// <summary>
        /// Общее количество кредитов
        /// </summary>
        private int maxCount;
        /// <summary>
        /// Название кредита
        /// </summary>
        private string CreditName;
        /// <summary>
        /// Описание кредита
        /// </summary>
        private string CreditDescription;

        /// <summary>
        /// Установка общего количества кредитов
        /// </summary>
        private void SetUpMaxCount()
        {
            maxCount = InteractionDB.CountCreditTypes()-1;
        }
        /// <summary>
        /// Обнуление текущего кол-ва кредитов
        /// </summary>
        private void ZeroCount()
        {
            count = 0;
        }

        /// <summary>
        /// Установка описания кредита
        /// </summary>
        /// <param name="curCount"></param>
        private void GetInfo(int curCount)
        {
            CreditName = InteractionDB.GetCreditName(count);
            CreditDescription = InteractionDB.GetDescriptionText(count);
        }
        /// <summary>
        /// Вывод информации на экран
        /// </summary>
        /// <param name="tb"></param>
        /// <param name="lb"></param>
        public void SetPage (RichTextBox tb, Label lb)
        {
            GetInfo(count);
            lb.Text = CreditName;
            tb.Text = CreditDescription;
        }
        public void SetPageWithCount(RichTextBox tb, Label lb, int numCount)
        {
            count = numCount;
            GetInfo(numCount);
            lb.Text = CreditName;
            tb.Text = CreditDescription;
        }
        public void IncreaseCount()
        {
            if (count != maxCount)
                count++;
            else count = 0;
        }
        public void DecreaseCount()
        {
            if (count != 0)
                count--;
            else count = maxCount;
        }
    }
}   
