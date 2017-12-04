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

        public CalcsPotr(Form f, GroupBox g) : base(f)
        {
            #region TrackBars creating
            trackSum = new TrackBar();
            trackSum.Location = new Point(16, 160);
            trackSum.Size = new Size(332, 45);
            trackSum.Maximum = 3000000;
            trackSum.LargeChange = 10000;
            f.Controls.Add(trackSum);

            trackDur = new TrackBar();
            trackDur.Location = new Point(16, 279);
            trackDur.Size = new Size(332, 45);
            trackDur.Maximum = 5;
            trackDur.LargeChange = 1;
            f.Controls.Add(trackDur);
            #endregion
            #region LabelCreating
            labelSumDesc = new Label();
            labelSumDesc.Location = new Point(16, 140);
            labelSumDesc.Font = new Font(labelSumDesc.Font.Name, labelSumDesc.Font.Size + 2);
            labelSumDesc.Text = "Необходимая сумма:";

            labelSum = new Label();
            labelSum.Location = new Point(200, 140);
            labelSum.Font = new Font(labelSum.Font.Name, labelSum.Font.Size + 2);
            labelSum.Text = "";
                
            labelDurDesc = new Label();
            labelDurDesc.Location = new Point(16, 140);
            labelDurDesc.Font = new Font(labelDurDesc.Font.Name, labelDurDesc.Font.Size + 2);
            labelDurDesc.Text = "Срок кредита:";

            labelDur = new Label();
            labelDur.Location = new Point(200, 140);
            labelDur.Font = new Font(labelDur.Font.Name, labelDur.Font.Size + 2);
            labelDur.Text = "";

            labelMonthlyPayDesc = new Label();
            labelMonthlyPayDesc.Location = new Point(5, 30);
            labelMonthlyPayDesc.Font = new Font(labelMonthlyPayDesc.Font.Name, labelMonthlyPayDesc.Font.Size + 2);
            labelMonthlyPayDesc.Text = "Ежемесячный платеж";

            labelRateDesc = new Label();
            labelRateDesc.Location = new Point(200, 140);
            labelRateDesc.Font = new Font(labelRateDesc.Font.Name, labelDur.Font.Size + 2);
            labelRateDesc.Text = "Процентная ставка: 12,9%";

            labelDur = new Label();
            labelDur.Location = new Point(200, 140);
            labelDur.Font = new Font(labelDur.Font.Name, labelDur.Font.Size + 2);
            labelDur.Text = "";
            #endregion
        }
    }
}
