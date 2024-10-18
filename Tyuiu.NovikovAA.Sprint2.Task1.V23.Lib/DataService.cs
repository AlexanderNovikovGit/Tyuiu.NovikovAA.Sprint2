using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NovikovAA.Sprint2.Task1.V23.Lib
{
    public class DataService : ISprint2Task1V23
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];
            result[0] = (a > b | c < d);
            result[1] = (a > b & c < d);
            result[2] = (a > b || c < d);
            result[3] = (a < b && c > d);
            result[4] = !(a > b);
            result[5] = (a < b ^ c == d);

            return result;

        }
    }
}
