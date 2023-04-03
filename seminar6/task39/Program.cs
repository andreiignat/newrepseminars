/* Напишите программу РЕВЕРС массива одномерного*/

int[] array = CreateArray(6);


PrintArray(array);
array = ReverseArray(array);
PrintArray(array);

int[] ReverseArray(int[] arrayT)
{
    int[] array2 = new int[arrayT.Length];
    int i = 0;
    int j = arrayT.Length -1;
    while (j >= 0)
    {
        array2[i] = arrayT[j];
        i++;
        j++;

    }
    return array2;
}

int[] CreateArray(int size, int min = 0, int max = 9)
{
    int[] arrayT = new int [size];
    for(int i = 0; i < size; i++)
        arrayT[i] = new Random().Next(min, max+1);
    return arrayT;
}

void PrintArray(int[] arrayT)
{
    for(int i = 0; i < arrayT.Length; i++)
        Console.Write($"{arrayT[i]}");
    Console.WriteLine();
}