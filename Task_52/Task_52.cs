/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

//------ ОСНОВНАЯ ПРОГРАММА -------

Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int columns =  int.Parse(Console.ReadLine()!);
int [,] array = GetArray (rows, columns, 0, 100);

for (int j = 0; j < array.GetLength(1); j++)
{
    double average = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        average = (average + array[i, j]);
    }
    average = average / columns;
    average = Math.Round(average, 1);
    Console.Write (average + "; ");
}
Console.WriteLine();
PrintArray(array);


// ------ МЕТОДЫ ------

// МЕТОД СОЗДАНИЯ ДВУМЕРНОГО МАССИВА

int [,] GetArray(int m, int n, int minValue, int maxValue)
{
    int [,] result = new int [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result [i,j] = new Random().Next(minValue, maxValue + 1);
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