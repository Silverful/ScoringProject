using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scoringProject.Logic
{
    public class CreditListShow
    {
        private CreditListShow()
        {
            this.SetUpMaxCount();
        }

        private static CreditListShow instance = null;
        public static CreditListShow getInstance()
        {
            if (instance == null)
            {
                instance = new CreditListShow();
                
            }
            return instance;
        }

        private int count = 0;
        private int maxCount;
        private string CreditName;
        private string CreditDescription;

        private void SetUpMaxCount()
        {
            maxCount = InteractionDB.CountCreditTypes()-1;
        }
        private void ZeroCount()
        {
            count = 0;
        }

        private void GetInfo(int curCount)
        {
            CreditName = InteractionDB.GetCreditName(count);
            CreditDescription = InteractionDB.GetDescriptionText(count);
        }
        public void SetPage (RichTextBox tb, Label lb)
        {
            GetInfo(count);
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
