using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using scoringProject.Logic;

namespace UnitTestProject1
{
    [TestClass]
    public class DBConnectionTest
    {
        [TestMethod]
        public void ChangeConnectionStringTest()
        {
            //set
            string serverAdress = "127.0.0.2";
            string user = "root";
            string database = "scoringdb";
            string port = "3006";
            string password = "123";
            string expected = "server=127.0.0.2; user=root;database=scoringdb;port=3006;password=123";

            //actual
            DBConnection.ChangeConnectionString(serverAdress, user, database, port, password);
            string actual = DBConnection.ConnectionString;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
