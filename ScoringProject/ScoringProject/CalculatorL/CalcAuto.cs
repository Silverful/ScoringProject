using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scoringProject.CalculatorL
{
    public class CalcAuto : CalcParent, ICalc
    {
        public CalcAuto(Form f, GroupBox g) : base(f)
        {
        }
    }
}
