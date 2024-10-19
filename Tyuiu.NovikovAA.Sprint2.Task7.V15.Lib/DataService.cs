using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NovikovAA.Sprint2.Task7.V15.Lib
{
    public class DataService : ISprint2Task7V15
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if (y >= 0 && y <= 2)
            {
                if ((Math.Sqrt((x * x) + (y * y)) <= 2) && (x >= -2) && (x <= 2))
                {
                    if (((Math.Sqrt((x * x) + (y * y)) <= 1) && (x >= -1 && x >= 1) && (y <= 1)))
                    {
                        return false;
                    }
                    else return true;
                }
                else { return false; }
            }
            else { return false; }
        }
    }
}
