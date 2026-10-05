using Tyuiu.KorovinMK.Sprint2.Task0.V27.Lib;
namespace Tyuiu.KorovinMK.Sprint2.Task0.V27
{
    class Program
    {

        public static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 1305;
            int y = 275;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.Title = "Спринт #2 | Выполнлил: Коровин М. К| ИСНТб-26-1";

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                 *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                          *");
            Console.WriteLine("* Задание #0                                                                *");
            Console.WriteLine("* Вариант #27                                                               *");
            Console.WriteLine("* Выполнил: Коровин Матвей Константинович| ИСТНб-26-1                       *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,           *");
            Console.WriteLine("* последовательность операций не должна нарушаться) и арифметических        *");
            Console.WriteLine("* выражений, которая вернет логическую последовательность(массив):          *");
            Console.WriteLine("* (True, False, True, False, False, True), при x = 1305, y = 275            *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);


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

