using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace scoringProject.Props
{
    public static class TextBoxFactory
    {
        public static TextBox CreateFactory(Point location, Form f)
        {
            TextBox box = new TextBox();
            box.Size = new Size(new Point(150, 20));
            box.Location = location;
            f.Controls.Add(box);
            return box;
        }
    }
}
