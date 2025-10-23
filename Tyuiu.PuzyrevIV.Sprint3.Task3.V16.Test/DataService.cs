using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PuzyrevIV.Sprint3.Task3.V16.Lib;

namespace Tyuiu.PuzyrevIV.Sprint3.Task3.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();

            string str = "ice nice ice creamcc";
            char chr = 'c';

            double res = ds.GetCharCount(str, chr);

            double wait = 6;

            Assert.AreEqual(wait, res);
        }
    }
}
