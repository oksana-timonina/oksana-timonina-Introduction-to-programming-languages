/* Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Write ("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
if (N < 0) 
{
    N = N*-1;
    Console.WriteLine ($"Число {-N} преобразовано в положительное число {N}");
}

Console.WriteLine ($"Таблица кубов чисел от 1 до {N}:");
for (int i = 1; i <= N; i++)
{
    
    Console.Write ($"{Math.Pow(i,3)} ");
}