using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace scoringProject.CalculatorL
{
    class CalcNecel : CalcParent, ICalc
    {
        public TrackBar trackSum { get; set; }
        public TrackBar trackDur { get; set; }
        public TrackBar trackFirstSum { get; set; }

        public Label labelSumDesc { get; set; }
        public Label labelSum { get; set; }
        public Label labelFirstSumDesc { get; set; }
        public Label labelFirstSum { get; set; }
        public Label labelDurDesc { get; set; }
        public Label labelDur { get; set; }

        public Label labelMonthlyPayDesc { get; set; }
        public Label labelFirstMonthPay { get; set; }
        public Label labelRateDesc { get; set; }
        public Label labelOverpayDesc { get; set; }
        public TextBox textBoxMonthlyPay { get; set; }
        public TextBox textBoxFirstMonthPay { get; set; }
        public TextBox textBoxOverPay { get; set; }

        public CalcNecel(Form f, GroupBox g) : base(f, g)
        {
            #region LeftPart
            labelSumDesc = labelFactory.CreateLabel("Необходимая сумма", new Point(15, 50));
            controlsLeft.Add(labelSumDesc);
            labelSum = labelFactory.CreateLabel("", new Point(200, 50));
            controlsLeft.Add(labelSum);
            trackSum = trackFactory.CreateTrack(30000000, 1700000, 100000, new Point(15, 70));
            controlsLeft.Add(trackSum);

            labelFirstSumDesc = labelFactory.CreateLabel("Первоначальный взнос", new Point(15, 130));
            controlsLeft.Add(labelFirstSumDesc);
            labelFirstSum = labelFactory.CreateLabel("", new Point(200, 130));
            controlsLeft.Add(labelFirstSum);
            trackFirstSum = trackFactory.CreateTrack(18000000, 700000, 10000, new Point(15, 150));
            controlsLeft.Add(trackFirstSum);

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

            labelFirstMonthPay = labelFactory.CreateLabel("Первоначальный взнос", new Point(10, 160));
            controlsRight.Add(labelFirstMonthPay);
            textBoxFirstMonthPay = textBoxFactory.CreateTextBox(new Point(10, 180));
            controlsRight.Add(textBoxFirstMonthPay);

            labelRateDesc = labelFactory.CreateLabel("Ставка 10%", new Point(10, 220));
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
