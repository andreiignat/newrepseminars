
int x1, x2, y1, y2;

Console.Write($"Введите координату х1: ");
int.TryParse(Console.ReadLine(), out x1);

Console.Write($"Введите координату у1: ");
int.TryParse(Console.ReadLine(), out y1);

Console.Write($"Введите координату х2: ");
int.TryParse(Console.ReadLine(), out x2);

Console.Write($"Введите координату у2: ");
int.TryParse(Console.ReadLine(), out y2);

 double x = (x2-x1)*(x2-x1);
 double y = (y2-y1)*(y2-y1);

 double res = Math.Sqrt(x + y);
 Console.WriteLine(res);