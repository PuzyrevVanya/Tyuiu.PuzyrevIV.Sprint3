using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PuzyrevIV.Sprint3.Task6.V18.Lib;

namespace Tyuiu.PuzyrevIV.Sprint3.Task6.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 9;
            int stopValue = 18;

            double res = ds.GetSumTheDivisors(startValue, stopValue);

            double wait = 221;

            Assert.AreEqual(wait, res);
        }
    }
}
