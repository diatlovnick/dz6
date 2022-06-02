/*
Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/

int GetNumber(string msg)
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double GetX(int k1, int k2, int b1, int b2)
{
    double b = b2 - b1;
    double k = k1 - k2;
    double x = b / k;
    Console.WriteLine();
    return x;
}

double GetY(int k1, int k2, int b1, int b2, double x)
{
    double y = k1 * x + b1;
    return y;
}

int k1 = GetNumber("введите k1");
int k2 = GetNumber("введите k2");
int b1 = GetNumber("введите b1");
int b2 = GetNumber("введите b2");

if (k1 != k2)
{
            
    double x = GetX(k1, k2, b1, b2);
    double y = GetY(k1, k2, b1, b2, x);
    Console.WriteLine($"{x}; {y}");
}

else
{
    Console.WriteLine("Прямые параллельны");
            
}


