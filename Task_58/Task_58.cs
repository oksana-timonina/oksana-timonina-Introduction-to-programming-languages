/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */


//------ ОСНОВНАЯ ПРОГРАММА -------
Console.WriteLine ("Задайте параметры для 1й матрицы. ");
Console.Write("Введите количество строк: ");
int rows1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns1 =  int.Parse(Console.ReadLine()!);

Console.WriteLine();

Console.WriteLine ("Задайте параметры для 2й матрицы. ");
Console.Write("Введите количество строк: ");
int rows2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns2 =  int.Parse(Console.ReadLine()!);

if (columns1 != rows2)
{
    Console.WriteLine();
    Console.WriteLine ("ОШИБКА: Число столбцов 1й матрицы не равняется числу строк 2й матрицы.");
    Console.WriteLine ("Нельзя выполнить умножение!");
}
else
{
int [,] array1 = GetArray (rows1, columns1, 0, 10);
int [,] array2 = GetArray (rows2, columns2, 0, 10);


Console.WriteLine();
Console.WriteLine("Матрица 1: ");

PrintArray (array1);

Console.WriteLine();
Console.WriteLine("Матрица 2: ");

PrintArray (array2);

Console.WriteLine();
Console.WriteLine("Результирующая матрица: ");
GetResultArray (array1, array2);

}

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

void GetResultArray (int[,] array1, int[,] array2)
{
int [,] resultArray = new int [array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            resultArray[i, j] = 0;

            for (int k = 0; k < array1.GetLength(1); k++)
            {
                resultArray[i, j] += array1[i, k] * array2[k, j];
            }
        }            
    }
            PrintArray(resultArray);
}

