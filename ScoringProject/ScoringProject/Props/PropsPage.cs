using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using scoringProject.Logic;
using System.Windows.Forms;
using System.Drawing;

namespace scoringProject.Props
{
    public class PropsPage: Form
    {
        public List<TextBox> Boxes = new List<TextBox>();
        public PropsPage()
        {
           
            this.Size = new Size(400, 200);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackgroundImage = scoringProject.Properties.Resources.фон1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            // PropsPageForm.ParentForm = Program.GlobalAuth;
            //this.MdiParent = Program.GlobalAuth;
            Boxes = new List<TextBox>()
            {
                TextBoxFactory.CreateFactory(new Point(15, 30), this),
                TextBoxFactory.CreateFactory(new Point(180, 30), this),
                TextBoxFactory.CreateFactory(new Point(15, 70), this),
                TextBoxFactory.CreateFactory(new Point(180, 70), this),
                TextBoxFactory.CreateFactory(new Point(15, 110), this)
            };
            LabelFactory.CreateLabel("Адрес сервера: ", new Point(15, 10), this);
            LabelFactory.CreateLabel("Имя пользователя: ", new Point(180, 10), this);
            LabelFactory.CreateLabel("Название базы данных: ", new Point(15, 50), this);
            LabelFactory.CreateLabel("Порт: ", new Point(180, 50), this);
            LabelFactory.CreateLabel("Пароль: ", new Point(15, 90), this);

            Button buttonOkay = new Button();
            buttonOkay.Text = "Принять";
            buttonOkay.Location = new Point(180, 110);
            buttonOkay.Size = new Size(70,20);
            buttonOkay.Click += ButtonOkay_Click;
            this.Controls.Add(buttonOkay);
            this.Show();

            Button buttonCancel = new Button();
            buttonCancel.Text = "Отмена";
            buttonCancel.Location = new Point(260, 110);
            buttonCancel.Size = new Size(70, 20);
            buttonCancel.Click += ButtonCancel_Click; ;
            this.Controls.Add(buttonCancel);
            this.Show();

        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.GlobalAuth.Enabled = true;
            Program.GlobalAuth.Select();
        }

        private void ButtonOkay_Click(object sender, EventArgs e)
        {
            PropsSaver saver = new PropsSaver();
            saver.SaveProps(Boxes);
            this.Close();
            Program.GlobalAuth.Enabled = true;
            Program.GlobalAuth.Select();
        }
    }
}
