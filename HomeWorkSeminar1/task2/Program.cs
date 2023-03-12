Console.WriteLine("введите первое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("а = " + a + " " + "b = " + b + " " + "max = " + a);
}
else
{
    Console.WriteLine("а = " + a + " " + "b = " + b + " " + "max = " + b);
}