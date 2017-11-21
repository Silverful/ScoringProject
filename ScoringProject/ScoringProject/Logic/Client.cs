using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace scoringProject.Logic
{
    public class Client
    {
        // Данный класс реализует паттерн проектирования - Singleton. В работающей версии приложения возможен
        // лишь один объект класса Client.
        #region ClientProps
        public int ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string INN { get; set; }
        public string Gender { get; set; }
        public string PassportSeries { get; set; }
        public string PassportNumber { get; set; }  
        public DateTime PassportDate { get; set; }
        public string PassportCode { get; set; }
        public string PassportPlace { get; set; }
        public string PhoneNumber { get; set; }
        public string HomePhoneNumber { get; set; }
        public string Email { get; set; }
        public string Education { get; set; }
        public string FamilyInstance { get; set; }

        #endregion
 

        #region AdressClientProps
        public string Index { get; set; }
        public string Region { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        #endregion


        /// <summary>
        /// Состояние клиента
        /// </summary>
        private static Client instance = null;
        /// <summary>
        /// Строка для запроса
        /// </summary>
        private static string sqlstatement;


        private Client() 
        {
        }
        public string SqlStatement
        {
            get
            {
                return sqlstatement;
            }
            set
            {

            }
        }

        public void CreateInsertStatement()
        {
            sqlstatement = "INSERT INTO CLIENT VALUES (" + sqlstatement + ")";
            
        }
        
        /// <summary>
        /// Создание класса Client и получение объекта
        /// </summary>
        /// 
        public static Client getInstance()
        {
            if (instance == null)
            {
                instance = new Client();
            }
            return instance;
        }

        /// <summary>
        /// Заполнение инстанса и одновременно строки SqlStatement
        /// </summary>
        /// <param name="gID"></param>
        /// <param name="gLogin"></param>
        /// <param name="gPassword"></param>
        /// <param name="gSurname"></param>
        /// <param name="gFirstName"></param>
        /// <param name="gPatronymic"></param>
        /// <param name="gDateOfBirth"></param>
        /// <param name="gPlaceOfBirth"></param>
        /// <param name="gINN"></param>
        /// <param name="gGender"></param>
        /// <param name="gPassportSeries"></param>
        /// <param name="gPassportNumber"></param>
        /// <param name="gPassportDate"></param>
        /// <param name="gPassportCode"></param>
        /// <param name="gPassportPlace"></param>
        /// <param name="gPhoneNumber"></param>
        /// <param name="gHomePhoneNumber"></param>
        /// <param name="gEmail"></param>
        /// <param name="gEducation"></param>
        /// <param name="gFamilyInstance"></param>
        /// <param name="gPermanentAdress"></param>
        public void FillInstance(string gLogin, string gPassword, string gSurname, string gFirstName, string gPatronymic,
            DateTime gDateOfBirth, string gPlaceOfBirth, string gINN, string gGender, string gPassportSeries, string gPassportNumber,
            DateTime gPassportDate, string gPassportCode, string gPassportPlace, string gPhoneNumber, string gHomePhoneNumber,
            string gEmail, string gEducation, string gFamilyInstance, string gAdressIndex, string gAdressRegion, string gAdressArea, string gCity)
        {
            ID = InteractionDB.CountNextID();
            sqlstatement += "'"+ ID.ToString() + "',";
            Login = gLogin;
            sqlstatement += "'" + gLogin + "',";
            Password = gPassword;
            sqlstatement += "'" + gPassword + "',";
            Surname = gSurname;
            sqlstatement += "'" + gSurname + "',";
            FirstName = gFirstName;
            sqlstatement += "'" + gFirstName + "',";
            Patronymic = gPatronymic;
            sqlstatement += "'" + gPatronymic + "',";
            DateOfBirth = gDateOfBirth;
            sqlstatement += "'" + gDateOfBirth.ToString() + "',";
            PlaceOfBirth = gPlaceOfBirth;
            sqlstatement += "'" + gPlaceOfBirth + "',";
            INN = gINN;
            sqlstatement += "'" + gINN + "',";
            Gender = gGender;
            sqlstatement += "'" + gGender + "',";
            PassportSeries = gPassportSeries;
            sqlstatement += "'" + gPassportSeries + "',";
            PassportNumber = gPassportNumber;
            sqlstatement += "'" + gPassportNumber + "',";
            PassportDate = gPassportDate;
            sqlstatement += "'" + gPassportDate.ToString() + "',";
            PassportCode = gPassportCode;
            sqlstatement += "'" + gPassportCode + "',";
            PassportPlace = gPassportPlace;
            sqlstatement += "'" + gPassportPlace + "',";
            PhoneNumber = gPhoneNumber;
            sqlstatement += "'" + gPhoneNumber + "',";
            HomePhoneNumber = gHomePhoneNumber;
            sqlstatement += "'" + gHomePhoneNumber + "',";
            Email = gEmail;
            sqlstatement += "'" + gEmail + "',";
            Education = gEducation;
            sqlstatement += "'" + gEducation + "',";
            FamilyInstance = gFamilyInstance;
            sqlstatement += "'" + gFamilyInstance + "',";
            Index = gAdressIndex;
            sqlstatement += "'" + gAdressIndex + "',";

            Region = gAdressRegion;
            sqlstatement += "'" + gAdressRegion + "',";

            Area = gAdressArea;
            sqlstatement += "'" + gAdressArea + "',";

            City = gCity;
            sqlstatement += "'" + gCity + "'";


        }


        /// <summary>
        /// Обнуление инстанса
        /// </summary>
        public void DestroyInstance()
        {
            instance = null;
        }
        
      /*  public static void Test()
        {
            string path = @"C:\Users\Антон\Desktop\TestLog.txt";
            string[] text = { instance.ID.ToString(), instance.Login, instance.Password, instance.Surname,instance.FirstName, instance.DateOfBirth.ToString(),
                instance.Education, instance.FamilyInstance, instance.PermanentAdress };
            using (StreamWriter OutPut = new StreamWriter(path))
            {
                foreach (string str in text)
                {
                    OutPut.WriteLine(str);
                    
                }
                OutPut.Close();
            }
        } */
    }
}
