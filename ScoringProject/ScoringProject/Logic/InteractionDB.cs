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
                    cl.CreateInsertStatement();
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
        /*  public static string CreateStatement(Client cl)
          {
              string Statement;
              Statement = "INSERT INTO client values (" + cl.ID.ToString() + cl.Login + cl.Password 

              return Statement; 
          }*/
    }
}
