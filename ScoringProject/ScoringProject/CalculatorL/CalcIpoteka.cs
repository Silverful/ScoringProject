using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scoringProject.CalculatorL
{
    public class CalcIpoteka : CalcParent, ICalc
    {
        public CalcIpoteka(Form f, GroupBox g) : base(f)
        {
        }
    }
}
