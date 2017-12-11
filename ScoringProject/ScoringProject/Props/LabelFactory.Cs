using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace scoringProject.Props
{
    public static class LabelFactory
    {
        public static void CreateLabel(string text, Point loc, Form f)
        {
            Label lab = new Label();
            lab.Text = text;
            lab.Location = loc;
            lab.AutoSize = true;
            lab.BackColor = Color.Transparent;
            lab.Font = new Font(lab.Font.FontFamily, lab.Font.Size + 2);
            f.Controls.Add(lab); 
        }
    }
}
