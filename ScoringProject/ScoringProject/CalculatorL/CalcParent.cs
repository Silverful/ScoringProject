using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace scoringProject.CalculatorL
{
    public abstract class CalcParent: ICalc
    {
        private Form f;

        public List<Control> controlsLeft;
        public List<Control> controlsRight;

        public Form form { get; set; }
        public GroupBox groupBox { get; set; }
        public LabelFactory labelFactory { get; set; }
        public TrackBarFactory trackFactory { get; set; }
        public TextBoxFactory textBoxFactory { get; set; }

        public CalcParent(Form f, GroupBox group)
        {
            form = f;
            groupBox = group;
            labelFactory = new LabelFactory();
            trackFactory = new TrackBarFactory();
            textBoxFactory = new TextBoxFactory();
            controlsLeft = new List<Control>();
            controlsRight = new List<Control>();
    }

        public virtual void SetResult()
        {

        }
        public void Initialize()
        {
            foreach (Control c in controlsLeft)
            {
                c.Location = new Point(c.Location.X, c.Location.Y + 20);
                form.Controls.Add(c);
            }
            foreach (Control c in controlsRight)
            {
                groupBox.Controls.Add(c);
            }
        }
        public void Clear()
        {
            foreach (Control c in controlsLeft)
            {
                form.Controls.Remove(c);
            }
            foreach (Control c in controlsRight)
            {
                groupBox.Controls.Remove(c);
            }
        }
    }
}
