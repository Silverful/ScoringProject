using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        }
        /// <summary>
        /// Метод, расчитывающий следущий ID
        /// </summary>
        /// <returns>Необходимый ID</returns>
        public static int CountNextID()
        {
            int ID = 0;
            return ID + 1;
        }
    }
}
