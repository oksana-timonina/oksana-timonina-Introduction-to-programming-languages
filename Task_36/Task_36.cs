/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях(индексы элементов должны быть нечетными(1,3,5 и тд)).

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

//------ОСНОВНАЯ ПРОГРАММА-------

//ввод данных пользователем
Console.Write ("Введите размер массива: ");
int size_A = int.Parse(Console.ReadLine()!);
//ввод переменной, задание массива + вызов функции
int[] Array = GetArray (size_A);

//вывод данных на консоль
Console.WriteLine ($"Массив: [{String.Join (", ", Array)}]");
Console.WriteLine ($"Сумма элементов массива, стоящих на нечётных позициях равна {GetSumNums(Array)}!");

// ------МЕТОДЫ-------

int [] GetArray (int size_P)
{
    int [] number = new int [size_P];
    for (int i = 0; i < number.Length; i++)
    {
        number [i] = new Random().Next(-100,100);
    }
    return number;    
}

int GetSumNums(int[] number)
{
    int sum = 0;
    for (int i = 0; i < number.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + number [i];
        }
    }
    return sum;
}