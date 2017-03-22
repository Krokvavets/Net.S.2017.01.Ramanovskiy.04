using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task3;


namespace Day3.Task3_MSTest
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }
        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\Data.xml",
           "TestCase",
           DataAccessMethod.Sequential)]
       [DeploymentItem("Day3.Task3,MSTest\\Data.xml")]
        [TestMethod]
        public void TestMethod1()
        {
            int targetNumber = Convert.ToInt32(TestContext.DataRow["targetNumber"]);
            int insert = Convert.ToInt32(TestContext.DataRow["insertNumber"]);
            int i = Convert.ToInt32(TestContext.DataRow["i"]);
            int j = Convert.ToInt32(TestContext.DataRow["j"]);
            int ExpectedResult = Convert.ToInt32(TestContext.DataRow["ExpectedResult"]);
            Assert.AreEqual(Task3.Task3.Insertion(targetNumber, insert, i, j), ExpectedResult);

        }
    }
}
