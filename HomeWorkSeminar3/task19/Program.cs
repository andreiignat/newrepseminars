﻿// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


int  a, t, e, b=0;


Console.Write($"Введите пятизначное число ");
int.TryParse(Console.ReadLine(), out a);
e = a;

if (a > 9999 && a < 99999)
{
    
    for(int i = 0; a > 0; i++)
    {
        t = a % 10;
        b = (b * 10) + t;
        a = a / 10;
    }
    if (e == b)
    {
        Console.WriteLine($"это число  палиндром");
    }
    else
    {
        Console.WriteLine("это число НЕ палиндром");
    }
}
else
{
    Console.WriteLine("Введено не верное число");
}