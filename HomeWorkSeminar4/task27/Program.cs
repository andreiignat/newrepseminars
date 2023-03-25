// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


int a, b;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine(), out a);



b = 0;
while(a > 0)
{
   b += a % 10;
   a = a / 10;

}

Console.Write(b);
