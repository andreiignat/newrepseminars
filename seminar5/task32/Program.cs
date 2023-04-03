// Задача 32. Напишите программу замена элементов массива, положительные на соответствующие отрецательные и наоборот.
// -4 -> 4
// 5 -> -5

int[] array = CreateArray (10, -9, 9);

for (int i = 0; i < array.Length; i++)
{
    array[i] *= -1;
    Console.Write($"{array}");
}


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

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    
        Console.Write($"{array[i]} ");
        Console.WriteLine();  
}

