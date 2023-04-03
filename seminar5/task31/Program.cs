// Задайте массив из 12 элкмкнтов, заполненный случ. числами от -9 9 
// Найдите сумму отрицательных и положительных элкмкнтов массива


int[] array = new int[12];

void FillArray(int[] array, int min = 0, int max = 9)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max +1);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
FillArray(array);
// int sumP = 0;
// int sumN = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0)
//         sumP += array[i];
//     else
//         sumN += array[i];
// }

// Console.Write($"Сумма отрицательных = {sumN}  Сумма положительных = {sumP}");