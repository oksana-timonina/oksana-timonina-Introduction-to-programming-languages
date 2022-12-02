// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/* 
Условие: 
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 
*/


// Вариант 1

Console.WriteLine ("Введите первое число: ");
int N1 = int.Parse (Console.ReadLine()!);

Console.WriteLine ("Введите второе число: ");
int N2 = int.Parse (Console.ReadLine()!);


if (N1<N2)
    {
        Console.WriteLine($" min = {N1}, max {N2}");
    }
    else
    {
        Console.WriteLine($" min = {N2}, max {N1}");
    }


// Вариант 2

/*
int N1 = 5;
Console.WriteLine ($" N1 = {N1}");

int N2 = 7;
Console.WriteLine ($" N2 = {N2}"); 

if (N1<N2)
    {
        Console.WriteLine($" min = {N1}, max {N2}");
    }
    else
    {
        Console.WriteLine($" min = {N2}, max {N1}");
    }
*/

/*
int N1 = 2;
Console.WriteLine ($" N1 = {N1}");

int N2 = 10;
Console.WriteLine ($" N2 = {N2}"); 

if (N1<N2)
    {
        Console.WriteLine($" min = {N1}, max {N2}");
    }
    else
    {
        Console.WriteLine($" min = {N2}, max {N1}");
    }    

*/
/*
int N1 = -3;
Console.WriteLine ($" N1 = {N1}");

int N2 = -9;
Console.WriteLine ($" N2 = {N2}"); 

if (N1<N2)
    {
        Console.WriteLine($" min = {N1}, max {N2}");
    }
    else
    {
        Console.WriteLine($" min = {N2}, max {N1}");
    }    
    */