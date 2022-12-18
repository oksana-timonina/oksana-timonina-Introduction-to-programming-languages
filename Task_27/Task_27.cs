/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

// 1 вариант программы
/*

Console.Write ("Введите число: ");
int num = int.Parse (Console.ReadLine()!); 
if (num < 0) 
{
    num = num*-1;
    Console.WriteLine ($"Число {-num} преобразовано в положительное число {num}");
}

Console.WriteLine ($"Сумма цифр в числе {num} равна {GetSumNums(num)}"); 

//-------------МЕТОД---------------
int GetSumNums (int number) 
{
    int sum = 0;

    while (number>0)
    {
        sum = sum + number%10;
        number/=10;
    }
    return sum;
}
*/
// 2 вариант программы

Console.Write ("Введите число: ");
int num = int.Parse (Console.ReadLine()!); 
Console.WriteLine ($"Сумма цифр в числе {num} равна {GetSumNums(num)}"); 

//-------------МЕТОД---------------
int GetSumNums (int number) 
{
    int sum = 0;
    bool flag = false;
    if (number < 0) 
{
    flag = true;
    number = number*-1; 
}

    while (number>10)
    {
        sum = sum + number%10;
        number/=10;
    }

    if(flag)
    {
        return sum - number;
    }
    else
    {
        return sum + number;
    }
    
}