using Tyuiu.KorovinMK.Sprint2.Task7.V7.Lib;
namespace Tyuiu.KorovinMK.Sprint2.Task7.V7
{
    class Program
    {

        public static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнлил: Коровин М. К| ИСНТб-26-1";

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                 *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                          *");
            Console.WriteLine("* Задание #7                                                                *");
            Console.WriteLine("* Вариант #7                                                                *");
            Console.WriteLine("* Выполнил: Коровин Матвей Константинович| ИСТНб-26-1                       *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            double x;
            double y;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);
                Console.WriteLine("*****************************************************************************");
                Console.WriteLine("Результат:                                                                  *");
                Console.WriteLine("*****************************************************************************");

            if (res)
            {
                Console.WriteLine("Точка находиться в закрашеном интервале");
            }
            else
            {
                Console.WriteLine("Точка не находиться в закрашеном интервале");
            }    

            Console.ReadLine();


        }
    }
}