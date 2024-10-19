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
                    res += "Шестёрка";
                    break;
                case 7:
                    res += "Семёрка ";
                    break;
                case 8:
                    res += "Восьмёрка ";
                    break;
                case 9:
                    res += "Девятка ";
                    break;
                case 10:
                    res += "Десятка ";
                    break;
                case 11:
                    res += "Валет ";
                    break;
                case 12:
                    res += "Дама ";
                    break;
                case 13:
                    res += "Король ";
                    break;
                case 14:
                    res += "Туз ";
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
