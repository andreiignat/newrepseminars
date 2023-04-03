int[] array = CreateArray(10, -9, 9);

if(Contain(array, 3))
Console.WriteLine($"Found");
else
Console.WriteLine($"Not found");


bool Contain(int[] array, int item)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == item)
            return true;
    return false;  
        
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
