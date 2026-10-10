using Tyuiu.KorovinMK.Sprint2.Task1.V8.Lib;
namespace Tyuiu.KorovinMK.Sprint2.Task1.V8
{
    class Program
    {

        public static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a = 15;
            int b = 16;
            int c = 14;
            int d = 335;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.Title = "Спринт #2 | Выполнлил: Коровин М. К| ИСНТб-26-1";

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                 *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                          *");
            Console.WriteLine("* Задание #1                                                                *");
            Console.WriteLine("* Вариант #8                                                                *");
            Console.WriteLine("* Выполнил: Коровин Матвей Константинович| ИСТНб-26-1                       *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,           *");
            Console.WriteLine("* последовательность можно чередовать , но использовать один раз в          *");
            Console.WriteLine("* выражении) и логических операций (|, &, ||, &&, !, ^, последовательность  *");
            Console.WriteLine("*  операций не должна нарушаться), а также арифметических выражений         *");
            Console.WriteLine("*, которая вернет логическую последовательность(массив):                    *");
            Console.WriteLine("*(True, False, True, False, False, False),                                  *");
            Console.WriteLine("* при a = 15, b = 16, c = 14, d = 335                                       *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine(" a = " + a);
            Console.WriteLine(" b = " + b);
            Console.WriteLine(" c = " + c);
            Console.WriteLine(" d = " + d);


            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("Результат:                                                                  *");
            Console.WriteLine("*****************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }


            Console.ReadLine();


        }
    }
}


