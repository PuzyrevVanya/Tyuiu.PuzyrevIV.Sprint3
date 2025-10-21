using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PuzyrevIV.Sprint3.Task1.V2.Lib;

namespace Tyuiu.PuzyrevIV.Sprint3.Task1.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Тема: Sprint #3. Оператор цикла while.                                  *");
            Console.WriteLine("* Задание #1. Вариант #2.                                                 *");
            Console.WriteLine("* Выполнил: Пузырев И.В. | СМАРТБ 25 - 1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая используя цикл for, вычисляет сумму ряда    *");
            Console.WriteLine("* по формуле S = Σ (x^2 * i) + 1, при x = 4.                              *");
            Console.WriteLine("* (i от 1 до 15)                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = 1;
            int stopValue = 15;
            double sumSeries = 0;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение рада = " + ds.GetSumSeries(startValue, stopValue));

            Console.ReadKey();
        }
    }
}
