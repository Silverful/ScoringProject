using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scoringProject.CalculatorL
{
    public static class CalculatorLogic
    {
        private static ICalc calc;

        public static ICalc InitializeCalc(Form form,GroupBox groupbox, string type)
        {
            calc = new CalculatorFactory().CreateCalc(form, groupbox, type);
            return calc;
        }
    }
}
