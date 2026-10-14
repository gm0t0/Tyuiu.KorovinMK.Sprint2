using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KorovinMK.Sprint2.Task7.V7.Lib
{
    public class DataService : ISprint2Task7V7
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if (((2 - Math.Pow(x, 2) - y) >= 0) && (y >= 0))
            {
                res = true;
            }
            else if (((2 - Math.Pow(x, 2) - y) >= 0) && (y < 0) && ( x - y <= 0))
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
