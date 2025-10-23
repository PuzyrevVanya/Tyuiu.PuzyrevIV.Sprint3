using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PuzyrevIV.Sprint3.Task4.V24.Lib;

namespace Tyuiu.PuzyrevIV.Sprint3.Task4.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Тема: Sprint #3. Использование операторов continue и break в циклах.    *");
            Console.WriteLine("* Задание #4. Вариант #24.                                                *");
            Console.WriteLine("* Выполнил: Пузырев И.В. | СМАРТБ 25 - 1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
            Console.WriteLine("* функции y=(sin(x)/x)+2 При х = 0 прервать цикл.                         *");
            Console.WriteLine("* Полученные значения перемножать.                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;
            
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Количество символов = " + ds.Calculate(startValue, stopValue));

            Console.ReadKey();
        }
    }
}
