using Tyuiu.KorovinMK.Sprint2.Task6.V13.Lib;
namespace Tyuiu.KorovinMK.Sprint2.Task6.V13
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
            Console.WriteLine("* Задание #6                                                                *");
            Console.WriteLine("* Вариант #13                                                               *");
            Console.WriteLine("* Выполнил: Коровин Матвей Константинович| ИСТНб-26-1                       *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("Введите год:");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите день:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 31 || m > 12)
            {
                Console.WriteLine("Ошибка");
            }
            else
            {
                var res = ds.FindDateOfNextDay(g, m, n);

                Console.WriteLine("*****************************************************************************");
                Console.WriteLine("Результат:                                                                  *");
                Console.WriteLine("*****************************************************************************");

                Console.WriteLine("Следущий день:" + res);

            }

            Console.ReadLine();


        }
    }
}