using Tyuiu.NovikovAA.Sprint2.Task1.V23.Lib;



Console.Title = "Спринт #2 | Выполнил: Новиков А. А. | РППб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Логические операции                                               *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #23                                                             *");
Console.WriteLine("* Выполнил: Новиков Александр Андреевич | РППб-24-1                       *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=)         *");
Console.WriteLine("* ) и и логических операций (|, &, ||, &&, !, ^)                          *");
Console.WriteLine("* которая вернет логическую последовательность(массив):                   *");
Console.WriteLine("* (False, False, False, True, True, True)                                 *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* a = 242, b = 571, c = 325, d = 155                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

bool[] res = new bool[6];
int a = 242, b = 571, c = 325, d = 155;

DataService ds = new DataService();

res = ds.GetLogicOperations(a, b, c, d);

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(res[i]);
}
