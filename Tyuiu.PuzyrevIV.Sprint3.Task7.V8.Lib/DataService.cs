using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PuzyrevIV.Sprint3.Task7.V8.Lib
{
    public class DataService : ISprint3Task7V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double term2;
                double denominator = 2.0 - x;
                if (Math.Abs(denominator) < 1e-9)
                {
                    term2 = 0.0;
                }
                else
                {
                    term2 = (Math.Cos(x) + 1.0) / denominator;
                }
                double fx = Math.Sin(x) + term2 + (2.0 * x);

                valueArray[count] = Math.Round(fx, 2);

                count++;
            }

            return valueArray;
        }
    }
}
