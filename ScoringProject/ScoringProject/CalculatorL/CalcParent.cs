using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scoringProject.CalculatorL
{
    public class CalcParent: ICalc
    {
        private Form f;

        public Form form { get; set; }
        public GroupBox groupBox { get; set; }

        public CalcParent(Form f, GroupBox group)
        {
            form = f;
            groupBox = group;
        }

        public CalcParent(Form f)
        {
            this.f = f;
        }

        public virtual void SetResult()
        {

        }
    }
}
