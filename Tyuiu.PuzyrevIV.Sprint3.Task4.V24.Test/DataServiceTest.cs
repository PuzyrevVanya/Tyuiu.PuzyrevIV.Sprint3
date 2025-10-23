using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PuzyrevIV.Sprint3.Task4.V24.Lib;

namespace Tyuiu.PuzyrevIV.Sprint3.Task4.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int startValue = 5;
            int stopValue = -5;

            double res = ds.Calculate(startValue, stopValue);

            double wait = 46.75;

            Assert.AreEqual(wait, res);
        }
    }
}
