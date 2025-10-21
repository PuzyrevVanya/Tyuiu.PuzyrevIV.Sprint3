using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PuzyrevIV.Sprint3.Task2.V11.Lib
{
    public class DataService : ISprint3Task2V11
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double SumSeries = 0;
            int k = startValue;
            
            do
            {
                SumSeries = SumSeries + (value / k * Math.Sqrt(3));
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(SumSeries, 3);
        }   
    }
}
