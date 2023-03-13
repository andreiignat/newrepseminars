// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine($"Введите число");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0 && n < 8)
    {
    if (n == 6 || n == 7)
    {
        Console.WriteLine("Это выходной");
    }
    else
    {
        Console.WriteLine("Это НЕ выходной");
    }
    }
else
{
    Console.WriteLine($"Нет такого дня недели");
}