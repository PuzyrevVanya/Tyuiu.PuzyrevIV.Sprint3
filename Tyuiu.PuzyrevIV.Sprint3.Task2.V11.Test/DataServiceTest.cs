using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PuzyrevIV.Sprint3.Task2.V11.Lib;

namespace Tyuiu.PuzyrevIV.Sprint3.Task2.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 5;
            int startValue = 1;
            int stopValue = 6;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            double wait = 51.962;

            Assert.AreEqual(wait, res);
        }
    }
}
