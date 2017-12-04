using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace scoringProject.CalculatorL
{
    public class CalcsPotr : CalcParent, ICalc
    {
        public TrackBar trackSum { get; set; }
        public TrackBar trackDur { get; set; }
        public Label labelSumDesc { get; set; }
        public Label labelSum { get; set;}
        public Label labelDurDesc { get; set; }
        public Label labelDur { get; set; }
        public Label labelMonthlyPayDesc { get; set; }
        public Label labelRateDesc { get; set; }
        public Label labelOverpayDesc { get; set; }
        public TextBox textBoxMonthlyPay { get; set; }
        public TextBox textBoxOverPay { get; set; }

        public CalcsPotr(Form f, GroupBox g) : base(f, g)
        {   
            #region LeftPart
            Label labelSumDesc = new Label();
            labelSumDesc.Location = new Point(15, 135);
            labelSumDesc.Font = new Font(labelSumDesc.Font.Name, labelSumDesc.Font.Size + 4);
            labelSumDesc.Text = "Необходимая сумма:";
            labelSumDesc.BackColor = Color.Transparent;
            labelSumDesc.AutoSize = true;
            controlsLeft.Add(labelSumDesc);

            labelSum = new Label();
            labelSum.Location = new Point(200, 135);
            labelSum.Font = new Font(labelSum.Font.Name, labelSum.Font.Size + 4);
            labelSum.Text = "";
            labelSum.BackColor = Color.Transparent;
            labelSum.AutoSize = true;
            controlsLeft.Add(labelSum);

            trackSum = trackFactory.CreateTrack(3000000, 0, 10000, new Point(15, 160));
            controlsLeft.Add(trackSum);

            labelDurDesc = new Label();
            labelDurDesc.Location = new Point(15, 225);
            labelDurDesc.Font = new Font(labelDurDesc.Font.Name, labelDurDesc.Font.Size + 4);
            labelDurDesc.Text = "Срок кредита:";
            labelDurDesc.BackColor = Color.Transparent;
            labelDurDesc.AutoSize = true;
            controlsLeft.Add(labelDurDesc);

            labelDur = new Label();
            labelDur.Location = new Point(200, 225);
            labelDur.Font = new Font(labelDur.Font.Name, labelDur.Font.Size + 4);
            labelDur.Text = "";
            labelDur.BackColor = Color.Transparent;
            labelDur.AutoSize = true;
            controlsLeft.Add(labelDur);

            trackDur = trackFactory.CreateTrack(5, 0, 1, new Point(15, 250));
            controlsLeft.Add(trackDur);

            #endregion
            #region RightPart
            labelMonthlyPayDesc = new Label();
            labelMonthlyPayDesc.Location = new Point(10, 100);
            labelMonthlyPayDesc.Font = new Font(labelMonthlyPayDesc.Font.Name, labelMonthlyPayDesc.Font.Size + 4);
            labelMonthlyPayDesc.Text = "Ежемесячный платеж";
            labelMonthlyPayDesc.AutoSize = true;
            labelMonthlyPayDesc.BackColor = Color.Transparent;
            controlsRight.Add(labelMonthlyPayDesc);

            textBoxMonthlyPay = textBoxFactory.CreateTextBox(new Point(10, 120));
            controlsRight.Add(textBoxMonthlyPay);

            labelRateDesc = new Label();
            labelRateDesc.Location = new Point(10, 170);
            labelRateDesc.Font = new Font(labelRateDesc.Font.Name, labelRateDesc.Font.Size + 4);
            labelRateDesc.Text = "Процентная ставка: 12,9%";
            labelRateDesc.AutoSize = true;
            labelRateDesc.BackColor = Color.Transparent;
            controlsRight.Add(labelRateDesc);

            labelOverpayDesc = new Label();
            labelOverpayDesc.Location = new Point(10, 220);
            labelOverpayDesc.Font = new Font(labelOverpayDesc.Font.Name, labelOverpayDesc.Font.Size + 4);
            labelOverpayDesc.Text = "Переплата";
            labelOverpayDesc.AutoSize = true;
            labelOverpayDesc.BackColor = Color.Transparent;
            controlsRight.Add(labelOverpayDesc);

            textBoxOverPay = textBoxFactory.CreateTextBox(new Point(10, 240));
            controlsRight.Add(textBoxOverPay);
            #endregion

            this.Initialize();

        }
    }
}
