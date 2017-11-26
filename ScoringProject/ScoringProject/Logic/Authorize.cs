using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace scoringProject.Logic
{
    /// <summary>
    /// Класс, производящий авторизацию пользователя
    /// </summary>
    static class Authorize
    {
        static public string Login { get; set; }
        static public string Pass { get; set; }

        /// <summary>
        /// Логин и пароль отправляется на проверку наличие в базе данных в класс InteractionDB
        /// В случае положительного результата производится заполнение класса Client данными из запроса (InteractionDB.StringResult)
        /// </summary>
        /// <param name="gLogin"></param>
        /// <param name="gPass"></param>
        /// <returns>Возвращает true, если логин и пароль находятся в базе данных</returns>
        static public bool Enter(TextBox gLogin, TextBox gPass)
        {
            bool IsEntered;
            Login = gLogin.Text;
            Pass = gPass.Text;

            IsEntered = InteractionDB.IsExists(Login, Pass);
            if (IsEntered)
            {
                Client cl = Client.getInstance();
                cl.FillInstance(InteractionDB.StringResult);
            }
            return IsEntered;
        }
    }
}
