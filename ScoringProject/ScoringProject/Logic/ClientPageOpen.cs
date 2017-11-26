using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace scoringProject.Logic
{
    /// <summary>
    /// Класс, производящий загрузку данных на страницу пользователя
    /// </summary>
    public class ClientPageOpen
    {
        public ClientPageOpen()
        {

        }
        /// <summary>
        /// Загрузка текстовых данных
        /// </summary>
        /// <param name="hello"></param>
        /// <param name="login"></param>
        /// <param name="fio"></param>
        /// <param name="date"></param>
        /// <param name="city"></param>
        public static void LabelChange(Label hello, Label login, Label fio, Label date, Label city)
        {
            Client cl = Client.getInstance();
            hello.Text = cl.FirstName;
            login.Text = cl.Login;
            fio.Text = cl.FirstName + " " + cl.Surname + " " + cl.Patronymic;
            date.Text = cl.DateOfBirth.Day.ToString() + "/" + cl.DateOfBirth.Month.ToString() + "/" + cl.DateOfBirth.Year.ToString();
            city.Text = cl.City;
        }
    }
}
