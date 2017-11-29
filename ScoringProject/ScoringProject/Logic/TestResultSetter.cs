using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scoringProject.Logic
{
    public static class TestResultSetter
    {
        public static int TotalSum { get; set; }
        public static int NeededSum { get; set; }
        public static string CreditType { get; set; }
        public static int ClientId { get; set; }
        public static string Result { get; set; }

        public static void InitializeSetter(int sum, string type, int id)
        {
            TotalSum = sum;
            CreditType = type;
            ClientId = id;
            GetNeededSum();
        }
        private static void GetNeededSum()
        {
            NeededSum = InteractionDB.GetTheNeededBall(CreditType);
            SetResult();
        }
        private static void SetResult()
        {
            if (TotalSum >= NeededSum)
                Result = "Одобрено";
            else Result = "Отклонено";
            InteractionDB.InsertResult(ClientId, TotalSum, CreditType, Result);
        }
    }
}
