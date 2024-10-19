using tyuiu.cources.programming.interfaces.Sprint2;



namespace Tyuiu.NovikovAA.Sprint2.Task5.V6.Lib
{
    public class DataService : ISprint2Task5V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string res = "";

            switch (value2)
            {
                case 6:
                    res += "шестёрка";
                    break;
                case 7:
                    res += "семёрка ";
                    break;
                case 8:
                    res += "восьмёрка ";
                    break;
                case 9:
                    res += "девятка ";
                    break;
                case 10:
                    res += "десятка ";
                    break;
                case 11:
                    res += "валет ";
                    break;
                case 12:
                    res += "дама ";
                    break;
                case 13:
                    res += "король ";
                    break;
                case 14:
                    res += "туз ";
                    break;

            }

            switch (value1)
            {
                case 1:
                    res += "пик";
                    break;
                case 2:
                    res += "треф";
                    break;
                case 3:
                    res += "бубен";
                    break;
                case 4:
                    res += "червей";
                    break;     
            }
            return res;
        }
    }
}
