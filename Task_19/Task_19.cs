/* 
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом(первое число равно последнему, второе равно предпоследнему).

14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine ("Введите 5-значное число: ");
string number = Console.ReadLine()!;
if (number.Length != 5)
{
    Console.WriteLine ("Введено неверное число!");
}
else
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine ($"Число {number} является палиндромом!");
    }
    
    else
    {
        Console.WriteLine ($"Число {number} не является палиндромом!");
    }
}