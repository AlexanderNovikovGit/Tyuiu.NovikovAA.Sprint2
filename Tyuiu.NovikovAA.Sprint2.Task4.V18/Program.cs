using Tyuiu.NovikovAA.Sprint2.Task4.V18.Lib;



Console.Title = "Спринт #2 | Выполнил: Новиков А. А. | РППб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                      *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #18                                                             *");
Console.WriteLine("* Выполнил: Новиков Александр Андреевич | РППб-24-1                       *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

double x, y;
double res;

Console.WriteLine("Введите x");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y");
y = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds  = new DataService();
Console.WriteLine(ds.Calculate(x, y));