/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

//------ ОСНОВНАЯ ПРОГРАММА -------
Console.WriteLine ("Задайте прямоугольный двумерный массив.");
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns =  int.Parse(Console.ReadLine()!);

if (rows == columns)
{
    Console.WriteLine ("Кол-во строк равно кол-ву столбцов,");
    Console.WriteLine ("Массив - НЕпрямоугольный!");
}
else
{
Console.Write("Введите минимальное значение элементов в массиве: ");
int min_range = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение элементов в массиве: ");
int max_range = int.Parse(Console.ReadLine()!);

int [,] array = GetArray (rows, columns, min_range, max_range);

Console.WriteLine();
Console.WriteLine("Исходный массив: ");

PrintArray (array);

NumberRowMinSumElements(array);


// ----------- МЕТОДЫ -----------

// МЕТОД СОЗДАНИЯ ДВУМЕРНОГО МАССИВА

int [,] GetArray(int m, int n, int minValue, int maxValue)
{
    int [,] result = new int [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result [i,j] = new Random().Next(min_range, max_range);            
        }
    }
    return result;
}

// МЕТОД ПЕЧАТИ ДВУМЕРНОГО МАССИВА
void PrintArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
         Console.Write ("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write ($" {array[i,j]}");
        }
        Console.WriteLine (" ]");
    }
}

// МЕТОД ВЫВОДА НОМЕРА СТРОКИ С НАИМЕНЬШЕЙ СУММОЙ ЭЛЕМЕНТОВ
void NumberRowMinSumElements(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.WriteLine();
    Console.Write($"Результат: {minSumRow + 1} строка");
}
}
