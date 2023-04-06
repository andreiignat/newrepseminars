// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



int a = Numbers("Введите число строк 1-й матрицы: ");
int b = Numbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int k = Numbers("Введите число столбцов 2-й матрицы: ");
int range1 = Numbers("Введите диапазон случайных чисел: от  ");
int range2 = Numbers("Введите диапазон случайных чисел: до ");

int[,] firstMartrix = new int[a, b];
CreateNewArray(firstMartrix);
Console.WriteLine($"Первая матрица:\n");
krintArray(firstMartrix);

int[,] secondMatrix = new int[b, k];
CreateNewArray(secondMatrix);
Console.WriteLine($"Вторая матрица:\n");
krintArray(secondMatrix);

int[,] resultMatrix = new int[a, k];

MultiklyMatrix(firstMartrix, secondMatrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:\n");
krintArray(resultMatrix);

void MultiklyMatrix(int[,] firstMartrix, int[,] secondMatrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secondMatrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

int Numbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateNewArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range1, range2);
        }
    }
}

void krintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}