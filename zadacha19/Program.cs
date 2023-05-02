// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет

// 12821 -> да

// 23432 -> да




void Chek(int num)
{
    int num4 = (num / 1000) % 10;
    int num2 = num % 100;
    num2 = num2 / 10;



    if (num % 10 == num / 10000 && num2 == num4)
        Console.WriteLine("Yes");
    else
        Console.WriteLine("No");
}






Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num<10000 | num>99999)
    Console.WriteLine("Число не подходит");
else 
    Chek(num);