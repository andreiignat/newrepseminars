// Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

int a, b;

Console.WriteLine($"введите номер строки");
int.TryParse(Console.ReadLine(), out a);

Console.WriteLine($"введите номер столбца");
int.TryParse(Console.ReadLine(), out b);


int[,] numbers = new int[10, 10];
FillArray(numbers);
Console.WriteLine();

if (a > numbers.GetLength(0) || b > numbers.GetLength(1))
    {
    Console.WriteLine("такого элемента нет");
    }
else
    {
    Console.WriteLine($"значение элемента строки {a} и столбца {b} равно =  {numbers[a - 1, b - 1]}");
    Console.WriteLine();
    }

PrintArray(numbers);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100) / 10;
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}    ");
        }
        Console.WriteLine();
    }
}