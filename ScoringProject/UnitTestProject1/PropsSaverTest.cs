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
    public class PropsSaverTest
    {
        [TestMethod]
        public void PropsSaveTest()
        {
            PropsPage propsPage = new PropsPage();
            propsPage.Boxes[0].Text = "0";
            propsPage.Boxes[1].Text = "1";
            propsPage.Boxes[2].Text = "2";
            propsPage.Boxes[3].Text = "3";
            propsPage.Boxes[4].Text = "4";
            string expected = "server=0; user=1;database=2;port=3;password=4";

            PropsSaver propsSaver = new PropsSaver();
            propsSaver.SaveProps(propsPage.Boxes);

            PropsLoader propsLoader = new PropsLoader();
            propsLoader.LoadSqlText();

            Assert.AreEqual(expected, propsLoader.SQLText);
        }
    }
}
