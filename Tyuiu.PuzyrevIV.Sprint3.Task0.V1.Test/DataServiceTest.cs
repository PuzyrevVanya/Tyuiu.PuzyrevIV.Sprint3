using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PuzyrevIV.Sprint3.Task0.V1.Lib;

namespace Tyuiu.PuzyrevIV.Sprint3.Task0.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int value = 4;
            int startValue = 1;
            int stopValue = 15;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            double wait = -60;

            Assert.AreEqual(wait, res);
        }
    }
}
