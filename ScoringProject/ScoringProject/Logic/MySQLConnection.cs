using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace scoringProject.Logic
{
    public static class MySQLConnection
    {
        static void Connect()
        {


            string connStr = "server = 127.0.0.2; user=root;database=scoringdb;port=3306;password=3453456";

            var conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Подключаемся к MySQL...");
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Соединение закрыто. Готово!");
        }
    }
}

