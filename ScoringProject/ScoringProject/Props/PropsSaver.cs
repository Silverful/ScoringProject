using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using scoringProject.Logic;
using System.IO;

namespace scoringProject.Props
{
    public class PropsSaver
    {
        public string sqltext { get; private set; }
        public string Path { get; private set; }
        public void SaveProps(List<TextBox> tb)
        {
            ChangeSqlText(tb);
            SaveSqlText();
        }
        public void SaveProps(string text)
        {
            ChangeSqlText(text);
            SaveSqlText();
        }
        private void ChangeSqlText(List<TextBox> tb)
        {
            DBConnection.ChangeConnectionString(tb[0].Text, tb[1].Text, tb[2].Text, tb[3].Text, tb[4].Text);
            sqltext = DBConnection.ConnectionString;
        }
        private void ChangeSqlText(string text)
        {
            DBConnection.ConnectionString = text;
            sqltext = text;
        }
        private void SaveSqlText()
        {
            string Dir = Directory.GetCurrentDirectory();
            Path = Dir + "\\MySQLAdress.txt";
            using (File.Create(Path)) ;
            FileInfo fileInf = new FileInfo(Path);           
            if (fileInf.Exists)
            {
                using (StreamWriter SW = new StreamWriter(Path, false, System.Text.Encoding.Default))
                {
                    SW.WriteLine(sqltext);
                }   
            }
            else
            {
                using (StreamWriter SW = new StreamWriter(Path, false, System.Text.Encoding.Default))
                {
                    SW.WriteLine(sqltext);
                }
            }
        }
    }
}
