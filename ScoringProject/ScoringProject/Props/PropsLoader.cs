using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using scoringProject.Logic;
using System.IO;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace scoringProject.Props
{
    public class PropsLoader
    {
        public string DefaultSQL { get; private set; } = "server = 127.0.0.2; user=root;database=scoringdb;port=3306;password=3453456";
        public string SQLText { get; set; }

        public PropsLoader()
        {
            DBConnection.ChangeConnectionString(DefaultSQL);
        }
        public void LoadSqlText()   
        {
            string Dir = Directory.GetCurrentDirectory();
            string Path = Dir + "\\MySQLAdress.txt";
            FileInfo fileInf = new FileInfo(Path);

            if (fileInf.Exists)
            {
                using (StreamReader streamRead = new StreamReader(Path, System.Text.Encoding.Default))
                {
                    SQLText = streamRead.ReadLine();
                }
                CheckConnection();
            }
            else
            {
                MessageBox.Show("Файла с сохраненными данными не существует, выберите в настройках адрес сервера.");
            }
        }
        private void CheckConnection()
        {
            DBConnection.ChangeConnectionString(SQLText);
            try
            {
                DBConnection.Connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невозможно установить соединение, возможно данные введены некорректно.");
            }
        }
    }
}
