
// Создайте программу которая принимает число N и выдает сумму чисел до 1 до N

// int a;
// Console.Write($"Введите число: ");
// int.TryParse(Console.ReadLine(), out a);

// int res (int a)
// {
//     int sum = 0;
//     for(int i = 1; i <= a; i++)
//     sum += i;
//     return sum;
// }

// Console.Write($"{a} -> {res(a)}");




// Создайте программу которая принимает число и выдает коллисчество чисел в этом числе

// int a;
// Console.Write($"Введите число: ");
// int.TryParse(Console.ReadLine(), out a);

// int Digits(int a)
// {
    
//     int k = 0;
//     while(a != 0)
//     {
//         a /= 10;
//         k++;
//     }
//     return k;
// }
// Console.Write($"{a} -> {Digits(a)}");

int[] array = new int [4];

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(10);
    Console.WriteLine($"array[{i}] = {array[i]}");
}