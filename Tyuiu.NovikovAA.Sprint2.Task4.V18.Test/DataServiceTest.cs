using Tyuiu.NovikovAA.Sprint2.Task4.V18.Lib;



Console.Title = "������ #2 | ��������: ������� �. �. | ����-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ������ #2                                                               *");
Console.WriteLine("* ����: ��������� ��������                                                *");
Console.WriteLine("* ������� #4                                                              *");
Console.WriteLine("* ������� #18                                                             *");
Console.WriteLine("* ��������: ������� ��������� ��������� | ����-24-1                       *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* �������:                                                                *");
Console.WriteLine("* �������� ��������� ��, ������� ����������� ����� ��������               *");
Console.WriteLine("* � ���������� � ��������� ��������� �� �����                             *");
Console.WriteLine("* � ������������ X,Y � �������������� �������.                            *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* �������� ������:                                                        *");
Console.WriteLine("***************************************************************************");


double x, y;
double res;

Console.WriteLine("������� x");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("������� y");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ���������:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds  = new DataService();
Console.WriteLine(ds.Calculate(x, y));