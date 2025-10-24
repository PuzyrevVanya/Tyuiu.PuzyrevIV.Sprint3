using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PuzyrevIV.Sprint3.Task7.V8.Lib;

namespace Tyuiu.PuzyrevIV.Sprint3.Task7.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Тема: Sprint #3. Добавление к решению итоговых проектов по спринту      *");
            Console.WriteLine("* Задание #7. Вариант #8.                                                 *");
            Console.WriteLine("* Выполнил: Пузырев И.В. | СМАРТБ 25 - 1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел,                     *");
            Console.WriteLine("* принадлежащих числовому отрезку [9, 18]                                 *");
            Console.WriteLine("* сумму всех делителей меньше 10                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Начало отрезка = " + startValue);
            Console.WriteLine("Конец отрезка = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+--------+---------+");
            Console.WriteLine("+    X   +   f(x)  +");
            Console.WriteLine("+--------+---------+");
            for (int i = 0; i <= len - 1; i++);
            {
                Console.WriteLine("|{0,5:d}     | {1, 5:f2}    |", startValue, stopValue);
                startValue++;
            }
            Console.WriteLine("+--------+---------+");
            Console.ReadKey();
        }
    }
}
