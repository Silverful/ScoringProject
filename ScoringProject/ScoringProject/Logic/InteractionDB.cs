using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace scoringProject.Logic
{
    /// <summary>
    /// Класс, осуществляющий взаимодействие с базой данных
    /// </summary>
    public static class InteractionDB
    {
        #region Блок для регистрации
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
        #endregion

        #region Блок для авторизации
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
        #endregion

        #region Блок для списка кредитов
        /// <summary>
        /// Метод для получения описания кредита
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public static string GetDescriptionText(int count)
        {
            string sqltext = "SELECT description from credittype where creditid = " + count.ToString();
            DBConnection.Connect();
            MySqlCommand cmd = new MySqlCommand(sqltext, DBConnection.Instance);
            string text;
            try
            {
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    text = Convert.ToString(result);
                }
                else text = "Информация не найдена";

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return text;
        }
        /// <summary>
        /// Метод для получения названия кредита
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public static string GetCreditName(int count)
        {
            string sqltext = "SELECT creditname from credittype where creditid = " + count.ToString();
            DBConnection.Connect();
            MySqlCommand cmd = new MySqlCommand(sqltext, DBConnection.Instance);
            string text;
            try
            {
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    text = Convert.ToString(result);
                }
                else text = "Информация не найдена";

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return text;
        }
        /// <summary>
        /// Метод для получения количества кредитов
        /// </summary>
        /// <returns></returns>
        public static int CountCreditTypes()
        {
            string sql = "SELECT COUNT(*) FROM credittype";
            DBConnection.Connect();
            int count = 0;
            if (DBConnection.Instance != null)
            {
                try
                {

                    MySqlCommand cmd = new MySqlCommand(sql, DBConnection.Instance);
                    object NextIDobj = cmd.ExecuteScalar();
                    if (NextIDobj != null)
                    {
                        count = Convert.ToInt32(NextIDobj);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            DBConnection.CloseConnection();
            return count;
        }
        #endregion

        #region Блок для анкетирования
        /// <summary>
        /// Метод возвращающий необходимый балл для прохождения
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static int GetTheNeededBall(string type)
        {
            int neededball = 0;
            var sqltext = "SELECT ball from credittype where creditname = '" + type + "'";
            DBConnection.Connect();

            MySqlCommand cmd = new MySqlCommand(sqltext, DBConnection.Instance);
            if (DBConnection.Instance != null)
                try
                {
                    object NeededBallOBJ = cmd.ExecuteScalar();
                    if (NeededBallOBJ != null)
                        neededball = Convert.ToInt32(NeededBallOBJ);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            DBConnection.CloseConnection();
            return neededball;
        }
        /// <summary>
        /// Метод добавляющий результат анкетирования в БД
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ball"></param>
        /// <param name="credittype"></param>
        /// <param name="result"></param>
        public static void InsertResult(int id, int ball, string credittype, string result)
        {
            string sqltext = "INSERT INTO result VALUES(" + id + "," + ball + ",'" + credittype + "','" + result + "')";
            DBConnection.Connect();
            MySqlCommand cmd = new MySqlCommand(sqltext, DBConnection.Instance);

            if (DBConnection.Instance != null)
            {
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            DBConnection.CloseConnection();
        }
        #endregion

        #region Блок для DataGridView
        /// <summary>
        /// Метод для получения данных для ДатаГрида
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DataSet FillDataGrid(int id)
        {
            DBConnection.Connect();
            string sqltext = "SELECT credittype, ball, result from result where clientid = " + id.ToString();
            DataSet ds = new DataSet();
            using (MySqlDataAdapter adap = new MySqlDataAdapter(sqltext, DBConnection.Instance))
            {
                adap.Fill(ds);
            }
            return ds;
        }
        #endregion
    }
}
