//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Point(double b1, double b2, double k1, double k2)
{
    double x;
    double y;
    x = (b2-b1)/(k1-k2);
    y = k1*x+b1;
    Console.WriteLine("Координаты пересечения двух прямых:(" + x + "; " + y + ")");
}

Console.WriteLine("Введите число b1: ");
string? NB1 = Console.ReadLine();
double num1 = double.Parse(NB1);

Console.WriteLine("Введите число b2: ");
string? NB2 = Console.ReadLine();
double num2 = double.Parse(NB2);

Console.WriteLine("Введите число k1: ");
string? NB3 = Console.ReadLine();
double num3 = double.Parse(NB3);

Console.WriteLine("Введите число k2: ");
string? NB4 = Console.ReadLine();
double num4 = double.Parse(NB4);

Point(num1, num2, num3, num4);
