using Tyuiu.KorovinMK.Sprint2.Task4.V2.Lib;
namespace Tyuiu.KorovinMK.Sprint2.Task4.V2
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
            Console.WriteLine("* Задание #4                                                                *");
            Console.WriteLine("* Вариант #2                                                                *");
            Console.WriteLine("* Выполнил: Коровин Матвей Константинович| ИСТНб-26-1                       *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу, которая вычесляет требуемое значение с использованием *");
            Console.WriteLine("* тернарного оператора, где пользователь вводит значния x и y с клавиатуры, *");
            Console.WriteLine("*                             ( x + 1)       (  y + 5 )                     *");
            Console.WriteLine("*  если x > y + 3, то z = x + ( -----) иначе ( ------ )                     *");
            Console.WriteLine("*                             (   y  )       (  y + 2 )                     *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x, y);


            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("Результат:                                                                  *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("Значение выражения:" + res);



            Console.ReadLine();


        }
    }
}

