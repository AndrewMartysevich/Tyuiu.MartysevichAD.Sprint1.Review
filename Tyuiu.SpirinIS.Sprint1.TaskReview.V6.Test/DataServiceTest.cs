using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SpirinIS.Sprint1.TaskReview.V6.Lib;

namespace Tyuiu.SpirinIS.Sprint1.TaskReview.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = -10;
            Assert.AreEqual(wait, res);
        }
    }
}
