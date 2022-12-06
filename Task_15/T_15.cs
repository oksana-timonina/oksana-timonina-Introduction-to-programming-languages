/* 
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным. Обязательна проверка на ввод числа <1 и >7

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine ("Введите число (от 1 до 7): ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 || number > 7)
{
    Console.WriteLine ("Введено неверное число!");
}
else
{
    Console.WriteLine ("Выходной день?");

    if (number == 6 || number == 7)
    {
        Console.WriteLine ("Да");
    }
    else
    {
        Console.WriteLine ("Нет");
    }
}