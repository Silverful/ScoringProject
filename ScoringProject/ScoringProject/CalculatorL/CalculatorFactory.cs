using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace scoringProject.CalculatorL
{
    public class CalculatorFactory
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
    public class LabelFactory
    {
        public Label CreateLabel(string text, Point location)
        {
            Label label = new Label();
            label.Text = text;
            label.Location = location;
            label.BackColor = Color.Transparent;
            label.Font = new Font(label.Name, label.Font.Size + 4);
            label.AutoSize = true;
            return label;
        }
    }
    public class TrackBarFactory
    {
        public TrackBar CreateTrack(int max, int min, int largechange, Point location)
        {
            TrackBar track = new TrackBar();
            track.Maximum = max;
            track.Minimum = min;
            track.LargeChange = largechange;
            track.Location = location;
            track.Size = new Size(330, 40);
            track.TickFrequency = max / 100;
          //  track.BackColor = Color.Transparent;

            return track;
        }
    }
    public class TextBoxFactory
    {
        public TextBox CreateTextBox(Point location)
        {
            TextBox textbox = new TextBox();
            textbox.Location = location;
            textbox.Size = new Size(160,20);
            textbox.ReadOnly = true;

            return textbox;
        }
    }
}
