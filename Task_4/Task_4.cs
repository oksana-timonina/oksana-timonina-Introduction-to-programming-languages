// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Условие
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/


// Вариант 1


Console.WriteLine ("Введите первое число: ");
int N1 = int.Parse (Console.ReadLine()!);

Console.WriteLine ("Введите второе число: ");
int N2 = int.Parse (Console.ReadLine()!);

Console.WriteLine ("Введите третье число: ");
int N3 = int.Parse (Console.ReadLine()!);

int max = N1;


if (N1>N2)
{
    max = N1;
}

else
{
    max = N2;
}
    
if (N3>max)
{
    max = N3;
    Console.WriteLine($"max = {N3}");
}
else
{
    Console.WriteLine($"max = {max}");
}
