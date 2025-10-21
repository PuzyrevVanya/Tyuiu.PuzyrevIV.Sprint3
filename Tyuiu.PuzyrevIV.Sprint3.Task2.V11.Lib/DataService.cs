using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PuzyrevIV.Sprint3.Task2.V14.Lib
{
    public class DataService : ISprint3Task2V14
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double SumSeries = 0;

            do
            {
                int k = startValue;

                SumSeries = SumSeries + (value / k * Math.Sqrt(3));
                startValue++;
            } while (startValue <= stopValue);

            return Math.Round(SumSeries, 3);
        }
    }
} 
