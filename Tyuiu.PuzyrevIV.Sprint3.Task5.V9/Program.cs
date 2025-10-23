using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PuzyrevIV.Sprint3.Task5.V9.Lib;

namespace Tyuiu.PuzyrevIV.Sprint3.Task5.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Тема: Sprint #3. Вложенные циклы.                                       *");
            Console.WriteLine("* Задание #3. Вариант #9.                                                 *");
            Console.WriteLine("* Выполнил: Пузырев И.В. | СМАРТБ 25 - 1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить y = Σ (Σ (1 / sin(k))) + x, где:                              *");
            Console.WriteLine("* Внешняя сумма по i от 1 до 3                                            *");
            Console.WriteLine("* Внутренняя сумма по k от 1 до 14                                        *");
            Console.WriteLine("* x = 5                                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 5;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 14;

            Console.WriteLine("Переменная X = " + x);
            Console.WriteLine("Старт шага первой суммы ряда = " + startValue1);
            Console.WriteLine("Конец шага  первой суммы ряда= " + stopValue1);
            Console.WriteLine("Старт шага второй суммы ряда = " + startValue2);
            Console.WriteLine("Конец шага второй суммы ряда= " + stopValue2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Количество символов = " + ds.Calculate(x, startValue1, startValue2, stopValue1, stopValue2));

            Console.ReadKey();
        }
    }
}