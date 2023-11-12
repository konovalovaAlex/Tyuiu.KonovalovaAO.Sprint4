using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KonovalovaAO.Sprint4.Task7.V25.Lib;
namespace Tyuiu.KonovalovaAO.Sprint4.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int rows = 4, colums = 3;
            int[,] mtrx = new int[rows, colums];
            string str = "348561792486";
            int res = ds.Calculate(rows, colums, str);
            Assert.AreEqual(73728, res);
        }
    }
}
