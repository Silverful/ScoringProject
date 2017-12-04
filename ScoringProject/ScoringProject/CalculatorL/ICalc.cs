using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scoringProject.CalculatorL
{
    public interface ICalc
    {
        void SetResult();
        void Initialize();
        void Clear();
    }
}
