using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KonovalovaAO.Sprint4.Task1.V12.Lib;
namespace Tyuiu.KonovalovaAO.Sprint4.Task1.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 6, 6, 6, 7, 7, 7, 5, 5, 8, 8, 9, 9, 5 };
            int wait = 3472875;
            var result = ds.Calculate(array);
            Assert.AreEqual(wait, result);
        }
    }
}
