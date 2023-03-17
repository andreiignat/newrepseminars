// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int  a, b=3;

Console.Write($"Введите число ");
int.TryParse(Console.ReadLine(), out a);

for (int i=1; i <= a; i++)
{
    double c = Math.Pow(i, b);
    Console.WriteLine(c);

}
