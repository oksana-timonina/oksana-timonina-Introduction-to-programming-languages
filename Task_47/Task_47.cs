﻿/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

//------ ОСНОВНАЯ ПРОГРАММА -------

Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int columns =  int.Parse(Console.ReadLine()!);
double [,] array = GetArray (rows, columns, -100, 100);
PrintArray (array);

// ------ МЕТОДЫ ------

// МЕТОД СОЗДАНИЯ ДВУМЕРНОГО МАССИВА

double [,] GetArray(int m, int n, int minValue, int maxValue)
{
    double [,] result = new double [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result [i,j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
            
        }
    }
    return result;
}

// МЕТОД ПЕЧАТИ ДВУМЕРНОГО МАССИВА
void PrintArray (double [,] array)
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
