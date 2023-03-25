// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4-> 16

int a, b;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine(), out a);
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine(), out b);

int sum = 1;

for(int i =0; i < b; i++ )
{
    
    sum = sum * a;
}

Console.Write(sum);