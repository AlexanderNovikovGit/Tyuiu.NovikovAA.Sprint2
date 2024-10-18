﻿using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.NovikovAA.Sprint2.Task0.V21.Lib
{
    public class DataService : ISprint2Task0V21
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = new bool[6];
            result[0] = x == y ;
            result[1] = x != y + 930;
            result[2] = x < y;
            result[3] = y > x;
            result[4] = x <= y;
            result[5] = y >= x;

            return result;
        }
    }
}
