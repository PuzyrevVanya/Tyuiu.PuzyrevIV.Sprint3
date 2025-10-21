using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PuzyrevIV.Sprint3.Task0.V1.Lib;

namespace Tyuiu.PuzyrevIV.Sprint3.Task0.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Тема: Sprint #3. Оператор цикла for.                                    *");
            Console.WriteLine("* Задание #0. Вариант #1.                                                 *");
            Console.WriteLine("* Выполнил: Пузырев И.В. | СМАРТБ 25 - 1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая используя цикл for, вычисляет сумму ряда    *");
            Console.WriteLine("* по формуле S = Σ (x^2 * i) + 1, при x = 4.                              *");
            Console.WriteLine("* (i от 1 до 15)                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int value = 4;
            int startSumValue = 1;
            int stopSumValue = 15;

            Console.WriteLine($"Переменная X = {value}");
            Console.WriteLine($"Старт шага = {startSumValue}");
            Console.WriteLine($"Конец шага = {stopSumValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма рада = " + ds.GetSumSeries(value, startSumValue, stopSumValue));

            Console.ReadKey();
        }
    }
}

