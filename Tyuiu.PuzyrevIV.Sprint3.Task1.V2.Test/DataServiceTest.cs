using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PuzyrevIV.Sprint3.Task1.V2.Lib;

namespace Tyuiu.PuzyrevIV.Sprint3.Task1.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int startValue =25;
            int stopValue = 10;

            double res = ds.GetSumSeries(startValue, stopValue);

            double wait = 2.968;

            Assert.AreEqual(wait, res);
        }
    }
}
