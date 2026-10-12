using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KorovinMK.Sprint2.Task2.V2.Lib
{
    public class DataService : ISprint2Task2V2
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((x >= 3) || (x <= 5) || (x >= 9) || (x <= 10) || (x == 12) &&
                (y == 3) || (x == 5) || (x >= 9) || (x <= 10) || (x == 12) &&
                (y == 4) || (x >= 5) || (x <= 10) || (x == 12) && (y == 5) ||
                (x >= 3) || (x <= 10) || (x >= 12) || (x <= 13) && (y == 6) ||
                (x >= 3) || (x <= 4) || (x >= 8) || (x <= 13) && (y == 7) ||
                (x >= 8) || (x <= 13) && (y == 8) || (x >= 7) || (x < 13) && 
                (y == 9) || (x >= 8) || (x < 10) && (y == 10) || (x >= 3) ||
                (x < 10) && (y == 11) || (x >= 4) || (x <= 7) && (y >= 12) || (y <= 13))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
