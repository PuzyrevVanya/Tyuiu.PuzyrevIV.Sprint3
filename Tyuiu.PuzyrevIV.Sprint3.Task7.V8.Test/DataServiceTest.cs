using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PuzyrevIV.Sprint3.Task7.V8.Lib;

namespace Tyuiu.PuzyrevIV.Sprint3.Task7.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 0.55;
            valueWaitArray[1] = 0.65;
            valueWaitArray[2] = 0.75;
            valueWaitArray[3] = 0.85;
            valueWaitArray[4] = 0.95;
            valueWaitArray[5] = 0.45;
            valueWaitArray[6] = 0.35;
            valueWaitArray[7] = 0.25;
            valueWaitArray[8] = 0.15;
            valueWaitArray[9] = 0.05;
            valueWaitArray[10] = 0.50;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
