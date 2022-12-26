﻿/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

//------ ОСНОВНАЯ ПРОГРАММА -------

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns =  int.Parse(Console.ReadLine()!);
int [,] array = GetArray (rows, columns, 0, 10);

Console.WriteLine();
Console.WriteLine("Исходный массив: ");
PrintArray (array);

Console.WriteLine();
Console.WriteLine("Отсортированный массив (по убыванию): ");
SortArray(array);
PrintArray (array);

// ----------- МЕТОДЫ -----------

// МЕТОД СОЗДАНИЯ ДВУМЕРНОГО МАССИВА

int [,] GetArray(int m, int n, int minValue, int maxValue)
{
    int [,] result = new int [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result [i,j] = new Random().Next(0, 10);            
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

// МЕТОД СОРТИРОВКИ ДВУМЕРНОГО МАССИВА ПО УБЫВАНИЮ
void SortArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}
