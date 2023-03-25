// Первый метод не принимает, не возвращает.

// void Method1()
// {
// Console.WriteLine("Автор ...");
// }
// Method1();


// Второй метод Принимает но не Возвращает.

// void Method2 (string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.Write(msg);
//         i++;

//     }
// }
// Method2("Привет", 4);


// Третий метод Не принимает но возвращает.

// int Method3() 
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);


// Четвертый метод Принимает Возвращает

// string Metod4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Metod4(10, "asdf");
// Console.WriteLine(res);


// string Metod4(int count, string text)
// {

//     string result = String.Empty;
//     for(int i = 0; i < count;i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Metod4(10, "asdf");
// Console.WriteLine(res);




// Таблица умножения For в For

// for(int i = 2; i <=10; i++)
// {
//     for( int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine ($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }


// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

// string text = "— Я думаю, — сказал князь, улыбаясь, — что";
// string Replace(string text,  char oldValue,  char newValue )
// {
//     string result = string.Empty;
//     int length = text.Length;
//     for(int i = 0; i < length; i++)
//      {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//      }
//      return result;

// }
// string newText = Replace(text, 'к', 'K');
// Console.WriteLine(newText);


int[] arr = { 1, 3, 4, 3, 2, 2, 6, 1, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
void selectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
            {
                minPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
selectionSort(arr);
PrintArray(arr);
