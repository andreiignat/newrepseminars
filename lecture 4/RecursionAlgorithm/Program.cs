

// string[,] table = new string[2, 5];

// table[1, 2]= "текст";

// for( int i = 0; i < 2; i++)
// {
//     for(int j = 0; j < 5; j++)
//     {
//         Console.WriteLine($"-{table[i, j]}-");
//     }

// }





void PrintArray(int[,] matr)  //Печать массива двумерного.
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr) // заполнение массива
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);
        }
        
    }
}



int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);
