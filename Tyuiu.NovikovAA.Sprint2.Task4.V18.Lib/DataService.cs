using tyuiu.cources.programming.interfaces.Sprint2;



namespace Tyuiu.NovikovAA.Sprint2.Task4.V18.Lib
{
    public class DataService : ISprint2Task4V18
    {
        public double Calculate(double x, double y)
        {
            double res = 0;
            res = x * 3 < y ? Math.Pow(6 + ((x - 1) / (y*y*y)), x) : x + (10 * y) - (1 / x);
            res = Math.Round(res, 3);
            return res;
        }
    }
}
