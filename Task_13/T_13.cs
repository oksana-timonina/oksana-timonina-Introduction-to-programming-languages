/* Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет. 
Берем числа до 100000.

645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine ("Введите число (от 1 до 100000): ");
int Number = Convert.ToInt32(Console.ReadLine());
string strN = Number.ToString();


if (Number < 1 || Number > 100000)
{
    Console.WriteLine ("Введено неверное число!");
}
else
{
    if (strN.Length < 3)
    {
        Console.WriteLine ("Третьей цифры нет!");
    }
    else
    {
        Console.WriteLine ($"Третья цифра числа {Number} = {strN [2]}");
    }
}

