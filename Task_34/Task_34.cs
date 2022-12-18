/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2  */

//------ОСНОВНАЯ ПРОГРАММА-------

//ввод данных пользователем
Console.Write ("Введите размер массива: ");
int size_A = int.Parse(Console.ReadLine()!);
//ввод переменной, задание массива + вызов функции
int[] Array = GetArray (size_A);

//вывод данных на консоль
Console.WriteLine ($"Массив: [{String.Join (", ", Array)}]");
Console.WriteLine ($"Всего {size_A} чисел, {GetCount (Array)} из них чётные!");

// ------МЕТОДЫ-------

int [] GetArray (int size_P)
{
    int [] result = new int [size_P];
    for (int i = 0; i < result.Length; i++)
    {
        result [i] = new Random().Next(99,1000);
    }
    return result;    
}

int GetCount (int[] result)
{
    int count = 0;
    // foreach (int i in result) -- error Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.
   for (int i = 0; i < result.Length; i++)
    {
        if (result [i] % 2 == 0)
        {
            count++;
        }    
    }
    return count;
}

