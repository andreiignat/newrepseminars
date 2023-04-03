// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6]-> 0

int[] array = CreateArray(10, 1, 20);
int sum = 0;

for (int i = 0; i < array.Length; i = i + 2)
{
    sum += array[i];

}

Console.WriteLine($"сумма = {sum}");

int[] CreateArray(int size, int min = 0, int max = 9)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}