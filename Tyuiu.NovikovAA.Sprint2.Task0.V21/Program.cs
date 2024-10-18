using Tyuiu.NovikovAA.Sprint2.Task0.V21.Lib;




Console.Title = "Спринт #2 | Выполнил: Новиков А. А. | РППб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Операции сравнения                                                *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #21                                                             *");
Console.WriteLine("* Выполнил: Новиков Александр Андреевич | РППб-24-1                       *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
Console.WriteLine("* последовательность операций не должна нарушаться) и арифметических      *");
Console.WriteLine("* выражений, которая вернет логическую последовательность(массив):        *");
Console.WriteLine("* (False, False, False, False, False, False), при x = 1705, y = 775       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* x = 1705, y = 775                                                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int x = 1705; int y = 775; 

DataService ds  = new DataService();
bool[] res = new bool[6];
res = ds.GetCompareOperations(x, y);

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(res[i]);
}