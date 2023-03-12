Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

if (n != 1)
{
     for ( int i = 0; i <= n; i = i+2)
     {      

     Console.WriteLine(i);
     }
}
else
{
     Console.WriteLine("Число 1");
}