using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PuzyrevIV.Sprint3.Task2.V11.Lib;

namespace Tyuiu.PuzyrevIV.Sprint3.Task2.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Тема: Sprint #3. Оператор цикла do-while.                               *");
            Console.WriteLine("* Задание #2. Вариант #11.                                                *");
            Console.WriteLine("* Выполнил: Пузырев И.В. | СМАРТБ 25 - 1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая используя цикл do...while, которая вычисляет*");
            Console.WriteLine("* произведение ряда по формуле, при x = 5 П = = (x / k)*k*3               *");
            Console.WriteLine("* (i от 1 до 6)                                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double value = 5;
            int startValue = 1;
            int stopValue = 6;

            Console.WriteLine("Переменая Х = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма рада = " + ds.GetSumSeries(value, startValue, stopValue));

            Console.ReadKey();
        }
    }
}
