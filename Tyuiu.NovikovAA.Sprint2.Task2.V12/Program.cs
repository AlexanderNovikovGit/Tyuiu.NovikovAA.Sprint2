using Tyuiu.NovikovAA.Sprint2.Task2.V12.Lib;



Console.Title = "Спринт #2 | Выполнил: Новиков А. А. | РППб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                      *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #12                                                             *");
Console.WriteLine("* Выполнил: Новиков Александр Андреевич | РППб-24-1                       *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу на, которая запрашивает целые значения               *");
Console.WriteLine("* с клавиатуры и вычисляет находится ли точка                             *");
Console.WriteLine("* с координатами X,Y в заштрихованной области.                            *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int x, y;

Console.WriteLine("Введите x");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y");
y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

bool res = false;
DataService ds = new DataService();

res = ds.CheckDotInShadedArea(x, y);

Console.WriteLine(res);