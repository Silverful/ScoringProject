using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace scoringProject.CalculatorL
{
    public class CalcIpoteka : CalcParent, ICalc
    {
        public TrackBar trackSum { get; set; }
        public TrackBar trackDur { get; set; }
        public TrackBar trackHaveSum { get; set; }

        public Label labelSumDesc { get; set; }
        public Label labelSum { get; set; }
        public Label labelHaveSumDesc { get; set; }
        public Label labelHaveSum { get; set; }
        public Label labelDurDesc { get; set; }
        public Label labelDur { get; set; }

        public Label labelMonthlyPayDesc { get; set; }
        public Label labelHaveMonthPay { get; set; }
        public Label labelRateDesc { get; set; }
        public Label labelOverpayDesc { get; set; }
        public TextBox textBoxMonthlyPay { get; set; }
        public TextBox textBoxHaveMonthPay { get; set; }
        public TextBox textBoxOverPay { get; set; }
        public CalcIpoteka(Form f, GroupBox g) : base(f, g)
        {
            #region LeftPart
            labelSumDesc = labelFactory.CreateLabel("Необходимая сумма", new Point(15, 50));
            controlsLeft.Add(labelSumDesc);
            labelSum = labelFactory.CreateLabel("", new Point(200, 50));
            controlsLeft.Add(labelSum);
            trackSum = trackFactory.CreateTrack(30000000, 300000, 100000, new Point(15, 70));
            controlsLeft.Add(trackSum);

            labelHaveSumDesc = labelFactory.CreateLabel("У меня есть", new Point(15, 130));
            controlsLeft.Add(labelHaveSumDesc);
            labelHaveSum = labelFactory.CreateLabel("", new Point(200, 130));
            controlsLeft.Add(labelHaveSum);
            trackHaveSum = trackFactory.CreateTrack(5000000, 45000, 10000, new Point(15, 150));
            controlsLeft.Add(trackHaveSum);

            labelDurDesc = labelFactory.CreateLabel("Срок кредита", new Point(15, 210));
            controlsLeft.Add(labelDurDesc);
            labelDur = labelFactory.CreateLabel("", new Point(200, 210));
            controlsLeft.Add(labelDur);
            trackDur = trackFactory.CreateTrack(30, 1, 5, new Point(15, 230));
            controlsLeft.Add(trackDur);
            #endregion
            #region
            labelMonthlyPayDesc = labelFactory.CreateLabel("Ежемесячный платеж", new Point(10, 100));
            controlsRight.Add(labelMonthlyPayDesc);
            textBoxMonthlyPay = textBoxFactory.CreateTextBox(new Point(10, 120));
            controlsRight.Add(textBoxMonthlyPay);

            labelHaveMonthPay = labelFactory.CreateLabel("У меня есть", new Point(10, 160));
            controlsRight.Add(labelHaveMonthPay);
            textBoxHaveMonthPay = textBoxFactory.CreateTextBox(new Point(10, 180));
            controlsRight.Add(textBoxHaveMonthPay);

            labelRateDesc = labelFactory.CreateLabel("Ставка 9,4%", new Point(10, 220));
            controlsRight.Add(labelRateDesc);

            labelOverpayDesc = labelFactory.CreateLabel("Переплата", new Point(10, 260));
            controlsRight.Add(labelOverpayDesc);
            textBoxOverPay = textBoxFactory.CreateTextBox(new Point(10, 280));
            controlsRight.Add(textBoxOverPay);
            #endregion
            this.Initialize();
        }
    }
}
