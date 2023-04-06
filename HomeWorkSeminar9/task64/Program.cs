// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



int CheckNumber(string message)
{
    int a;
    Console.Write(message);
    int.TryParse(Console.ReadLine(), out a);
    return a;
}

int NaturalNumber(int k, int m)
{
    if (k == m) return k;
    else Console.Write($"{NaturalNumber(k, m + 1)}, ");
    return m;
}

int k = CheckNumber("Введите число: ");
if (k < 1)
{
    Console.WriteLine("Ввдите положительное число!");
    return;
}


Console.WriteLine(NaturalNumber(k, 1));