using Tyuiu.KorovinMK.Sprint2.Task2.V2.Lib;
namespace Tyuiu.KorovinMK.Sprint2.Task2.V2
{
    class Program
    {

        public static void Main(string[] args)
        { 
            Console.Title = "Спринт #2 | Выполнлил: Коровин М. К| ИСНТб-26-1";

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                 *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                          *");
            Console.WriteLine("* Задание #2                                                                *");
            Console.WriteLine("* Вариант #2                                                                *");
            Console.WriteLine("* Выполнил: Коровин Матвей Константинович| ИСТНб-26-1                       *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("*                                        *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("Введите значение X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);


            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("Результат:                                                                  *");
            Console.WriteLine("*****************************************************************************");

            if (res)
            {
                Console.WriteLine("Точка находиться в заштрихованной области.");
            }
            else
            {
                Console.WriteLine("Точка не находиться в заштрихованной области.");
            }
            


            Console.ReadLine();


        }
    }
}

