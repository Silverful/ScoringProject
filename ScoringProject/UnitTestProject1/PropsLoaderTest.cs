using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using scoringProject.Props;
using System.Drawing;

namespace UnitTestProject1
{
    [TestClass]
    public class PropsLoaderTest
    {
        [TestMethod]
        public void LoaderTest()
        {
            string expected = "server=127.0.0.2;user=root;database=scoringdb;port=3306;password=3453456";
            PropsLoader loader = new PropsLoader();

            loader.LoadSqlText();
            string actual = loader.SQLText;

            Assert.AreEqual(expected, actual);

        }
    }
}
