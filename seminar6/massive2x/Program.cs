// Двумерный массив
// Создаем функцию по заполнению двумерного массива


int[,] array = new int[3, 4];
Fill2DArray(array);
PrintArray(array, "array");

int[,] array2 = Create2DArray(3, 4);
PrintArray(array2, "array2");




int[,] Create2DArray(int rowCount, int columnCount )
{
    int[,] arrayT =new int[rowCount, columnCount];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(10);
    return array;
}


void Fill2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(10);  
}

void PrintArray(int[,] array, string title = "")
{
    if (title != "")
    {
        Console.Write($"{title}\n");
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)    
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}