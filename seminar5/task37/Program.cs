
int[] array = CreateArray(4, 2, 9);

int[] pairArray = PairMult(array);

PrintArray(pairArray);

int[] PairMult(int[] array)
{
        int newSize =array.Length / 2;
        if (array.Length % 2 !=0)
            newSize ++;

        int[] array2 = new int[newSize];
        for(int i = 0; i < newSize; i++)
            array2[i] = array[i] * array[array.Length - i -1];
        return array2;

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
