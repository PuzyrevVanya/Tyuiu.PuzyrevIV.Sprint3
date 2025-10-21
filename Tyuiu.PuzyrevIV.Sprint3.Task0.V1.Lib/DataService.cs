using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PuzyrevIV.Sprint3.Task0.V1.Lib
{
    public class DataService : ISprint3Task0V1
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sumSeries = 1995;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                sumSeries = sumSeries + (value - i);
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
