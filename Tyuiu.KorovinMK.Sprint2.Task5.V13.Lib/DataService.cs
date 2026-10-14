using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KorovinMK.Sprint2.Task5.V13.Lib
{
    public class DataService : ISprint2Task5V13
    {
        public string FindDateOfNextDay(int n, int m, int g)
        {
            int days = 0;
            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    days = 31;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30;
                    break;

                case 2:
                    days = 29;
                    break;

            }

            if (n < days)
            {
                n++;
            }
            else
            {
                n = 1;

                if (m == 12)
                {
                    m = 1;
                    g++;
                }
                else
                {
                    m++;
                }
            }
            
            var res = ("0" + n + ".0" + m + "." + g);
            return res;
                    
        }
            
    }
}
