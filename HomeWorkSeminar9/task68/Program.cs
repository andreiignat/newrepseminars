// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9
// m = 3, n = 2->A(m, n) = 29


int a, b;
Console.Write($"Введите первое положительное число: ");
int.TryParse(Console.ReadLine(), out a);

Console.Write($"Введите второе положительное число: ");
int.TryParse(Console.ReadLine(), out b);

CallFunctionOfAkkerman(a, b);

void CallFunctionOfAkkerman(int a, int b)
{
    Console.Write(FunctionOfAkkerman(a, b));
}

int FunctionOfAkkerman(int a, int b)
{
    if (a == 0)
    {
        return b + 1;
    }
    else if (b == 0 && a > 0)
    {
        return FunctionOfAkkerman(a - 1, 1);
    }
    else
    {
        return (FunctionOfAkkerman(a - 1, FunctionOfAkkerman(a, b - 1)));
    }
}