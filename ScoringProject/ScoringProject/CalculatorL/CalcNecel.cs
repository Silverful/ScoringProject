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
            labelSum = labelFactory.CreateLabel("1700000", new Point(200, 50));
            controlsLeft.Add(labelSum);
            trackSum = trackFactory.CreateTrack(30000000, 1700000, 100000, new Point(15, 70));
            controlsLeft.Add(trackSum);
            trackSum.ValueChanged += TrackSumChange;

            labelFirstSumDesc = labelFactory.CreateLabel("Первоначальный взнос", new Point(15, 130));
            controlsLeft.Add(labelFirstSumDesc);
            labelFirstSum = labelFactory.CreateLabel("700000", new Point(220, 130));
            controlsLeft.Add(labelFirstSum);
            trackFirstSum = trackFactory.CreateTrack(18000000, 700000, 10000, new Point(15, 150));
            controlsLeft.Add(trackFirstSum);
            trackFirstSum.ValueChanged += TrackFirstChange;

            labelDurDesc = labelFactory.CreateLabel("Срок кредита", new Point(15, 210));
            controlsLeft.Add(labelDurDesc);
            labelDur = labelFactory.CreateLabel("1", new Point(150, 210));
            controlsLeft.Add(labelDur);
            trackDur = trackFactory.CreateTrack(30, 1, 5, new Point(15, 230));
            controlsLeft.Add(trackDur);
            trackDur.ValueChanged += TrackDurChange;
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
        public void TrackSumChange(object sender, EventArgs e)
        {
            TrackBar track = (TrackBar)sender;
            labelSum.Text = track.Value.ToString();
        }
        public void TrackDurChange(object sender, EventArgs e)
        {
            TrackBar track = (TrackBar)sender;
            labelDur.Text = track.Value.ToString();
        }
        public void TrackFirstChange(object sender, EventArgs e)
        {
            TrackBar track = (TrackBar)sender;
            labelFirstSum.Text = track.Value.ToString();
        }
        public override void SetResult()
        {
            // Ежемесячный платеж = ((Необходимая сумма - Первоначальный взнос)*(1 + ставка) ^ срок в годах)/ (срок в годах *12)
            // Переплата = Ежемесячный платеж* Срок кредита(в месяцах) - сумма кредита


            if (trackDur.Value != 0)
            {
                textBoxMonthlyPay.Text = Convert.ToString(((trackSum.Value - trackFirstSum.Value) * Math.Pow(1.1, trackDur.Value) / (trackDur.Value * 12)));
            }
            else textBoxMonthlyPay.Text = "Срок кредита должен быть больше 0";

            if (trackDur.Value != 0)
            {
                textBoxOverPay.Text = Convert.ToString(Convert.ToDouble(textBoxMonthlyPay.Text) * (trackDur.Value * 12) - trackSum.Value);
            }
            else textBoxOverPay.Text = "";

            textBoxFirstMonthPay.Text = Convert.ToString(trackFirstSum.Value);
        }
    }
}
