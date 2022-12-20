/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел строго больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4 */

//------ОСНОВНАЯ ПРОГРАММА-------

//ввод данных пользователем
Console.Write ("Введите элементы массива (через пробел): ");
int [] arr = Array.ConvertAll(Console.ReadLine()!.Split(' '), int.Parse); 
GetCount (arr);

//string[] array_temp = Console.ReadLine()!.Split(','); ----- ввод переменных через запятую
//int [] arr1 = Array.ConvertAll(array_temp, Int32.Parse);


//вывод данных на консоль
Console.WriteLine ($"Массив: [{String.Join (", ", arr)}]");
Console.WriteLine($"Кол-во элементов > 0 равно {GetCount(arr)}!");

// -------МЕТОДЫ-------

int GetCount (int[] number)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
    
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

