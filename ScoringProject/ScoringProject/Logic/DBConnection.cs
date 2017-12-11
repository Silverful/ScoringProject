using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace scoringProject.Logic
{
    public static class DBConnection
    {
        private static MySqlConnection instance = null;
        private static string connectionString;

        /// <summary>
        /// Метод для изменения адреса базы данных
        /// </summary>
        /// <param name="server"></param>
        /// <param name="user"></param>
        /// <param name="database"></param>
        /// <param name="port"></param>
        /// <param name="password"></param>
        public static void ChangeConnectionString(string server, string user, string database, string port, string password)
        {
            connectionString = "server = " + server + "; user=" + user + ";database=" + database + ";port=" + port + ";password=" + password;
        }
        public static void ChangeConnectionString(string sqltext)
        {
            connectionString = sqltext;
        }
        /// <summary>
        /// Состояние соединения
        /// </summary>
        public static MySqlConnection Instance
        {
            get
            {
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        /// <summary>
        /// Строка соединения с БД
        /// </summary>
        public static string ConnectionString
        {
            get
            {
                return connectionString;
            }
            set
            {
                connectionString = value;
            }
        }

        /// <summary>
        /// Соединение с базой данных, используя свойство ConnectionString
        /// </summary>
        public static void Connect() 
        {
            if (instance == null || connectionString != null)
            {
                try
                {
                    var conn = new MySqlConnection(connectionString);

                    conn.Open();
                    instance = conn;
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Невозможно установить соединение с базой данных");
                }
            }
            return;
        }
        /// <summary>
        /// Закрытие соединения с базой данных и запуск Dispose()
        /// </summary>
        public static void CloseConnection()
        {
            if (instance != null)
            {
                using (instance)
                {
                    instance.Close();
                }
            }
        }

    }
}

