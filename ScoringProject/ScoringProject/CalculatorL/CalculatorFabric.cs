using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scoringProject.CalculatorL
{
    public class CalculatorFabric
    {
        public ICalc CreateCalc(Form form, GroupBox groupbox, string type)
        {
            ICalc calc;
            switch (type)
            {
                case "Ипотека":
                    calc = new CalcIpoteka(form, groupbox);
                    break;
                case "Потребительский кредит":
                    calc = new CalcsPotr(form, groupbox);
                    break;
                case "Нецелевой потребительский кредит":
                    calc = new CalcNecel(form, groupbox);
                    break;
                case "Автокредит":
                    calc = new CalcAuto(form, groupbox);
                    break;
                default:
                    throw new Exception();
            }
            return calc; 
        }
    }
}
