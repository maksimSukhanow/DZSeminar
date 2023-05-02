// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


double diss (double x, double y, double z, double x1, double y1, double z1)
{
    double disnance = Math.Sqrt((Math.Pow(x1 - x, 2)) + (Math.Pow(y1 - y, 2)) + (Math.Pow(z1 - z, 2)));
    return disnance;
}




Console.WriteLine("Введите первую координату");
double x = Convert.ToDouble(Console.ReadLine());
double y = Convert.ToDouble(Console.ReadLine());
double z = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите вторую координату");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Math.Round(diss(x,y,z,x1,y1,z1),2));