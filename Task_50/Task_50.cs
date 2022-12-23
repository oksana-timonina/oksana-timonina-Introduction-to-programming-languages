/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
i = 5; j = 2 -> такого числа в массиве нет
i = 1; j = 1 -> 9 */


//------ ОСНОВНАЯ ПРОГРАММА -------

Console.WriteLine("Введите номер строки: ");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите номер столбца: ");
int column =  int.Parse(Console.ReadLine()!);
int [,] array = GetArray (3, 4, 0, 10);

if (row > array.GetLength(0) || column > array.GetLength(1))
{
    Console.WriteLine("Такого элемента нет!");
}
else
{
    Console.WriteLine($"Значение элемента {row} строки и {column} столбца равно {array[row-1,column-1]}");
    PrintArray (array);
}


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