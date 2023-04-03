// Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int a, b;

Console.WriteLine($"введите кол-во строк");
int.TryParse(Console.ReadLine(), out a);

Console.WriteLine($"введите кол-во столбцов");
int.TryParse(Console.ReadLine(), out b);

int[,] numbers = new int[a, b];

FillArray(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        sum = (sum + numbers[i, j]);
    }
    sum = sum / a;
    Console.Write(sum + " ");
}


Console.WriteLine();
PrintArray(numbers);



void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)

        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}    ");
        Console.WriteLine();
    }
}