using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.NovikovAA.Sprint2.Task3.V25.Lib
{
    public class DataService : ISprint2Task3V25
    {
        public double Calculate(double x)
        {
            double res = 0;
            if (x > 1)
            {
                res = Math.Sin(x * x * x) + Math.Pow(((x + 1) / (x - 1)), x);
            }
            else if (x == 2)
            {
                res = (Math.Pow(x, 2) - (Math.Cos(x * x * x) / x - 3));
            }
            else if (x < 2 && x > -29)
            {
                res = (1 + (1 / (x * x)));
            }
            else if (x < -29)
            {
                res = x + 15 + (12 / x);
            }
            res = Math.Round(res,3);
            return res;
        }
    }
}
