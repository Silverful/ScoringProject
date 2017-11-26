using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace scoringProject.Logic
{
    /// <summary>
    /// Класс, осуществляющий взаимодействие с базой данных
    /// </summary>
    public static class InteractionDB
    {
        /// <summary>
        /// Метод, реализующий добавление клиента в базу данных
        /// </summary>
        /// <param name="cl">Состояние клиента</param>
        public static void AddClient(Client cl)
        {
            DBConnection.Connect();
            if (DBConnection.Instance != null)
            {
                try
                {
                    string Statement = cl.SqlStatement;
                    MySqlCommand cmd = new MySqlCommand(Statement, DBConnection.Instance);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                DBConnection.CloseConnection();
            }
        }
        /// <summary>
        /// Метод, расчитывающий следущий ID
        /// </summary>
        /// <returns>Необходимый ID</returns>
        public static int CountNextID()
        {
            string sql = "SELECT COUNT(*) FROM client";
            DBConnection.Connect();
            int NextID = 0;
            if (DBConnection.Instance != null)
            {
                try
                {

                    MySqlCommand cmd = new MySqlCommand(sql, DBConnection.Instance);
                    object NextIDobj = cmd.ExecuteScalar();
                    if (NextIDobj != null)
                    {
                        NextID = Convert.ToInt32(NextIDobj);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            DBConnection.CloseConnection();
            return NextID;
        }
        /// <summary>
        /// Список с результатами SELECT * запросов.
        /// </summary>
        public static List<string> StringResult = new List<string>();

        /// <summary>
        /// Метод проверяет, есть ли в базе данных пользователь с данными логином и паролем
        /// Если есть, то все параметры строки сохраняет в список StringResult
        /// </summary>
        /// <param name="Login"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public static bool IsExists(string Login, string Password)
        {
            bool result;

            DBConnection.Connect();
            try
            {
                string sqltext = "SELECT * FROM CLIENT WHERE login = '" + Login + "' AND password = '" + Password + "'";
                MySqlCommand cmd = new MySqlCommand(sqltext, DBConnection.Instance);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows == false)
                    result = false;
                else
                {
                    result = true;
                    while (rdr.Read())
                    {
                        for (int j = 0; j < rdr.FieldCount; j++)
                            StringResult.Add(rdr[j].ToString());
                    }
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            DBConnection.CloseConnection();
            return result; 
        }




        /*  public static string CreateStatement(Client cl)
          {
              string Statement;
              Statement = "INSERT INTO client values (" + cl.ID.ToString() + cl.Login + cl.Password 

              return Statement; 
          }*/
    }
}
