/* Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
второй и предпоследний и т.д. Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3

[6 7 3 6] -> 36 21*/

//------ОСНОВНАЯ ПРОГРАММА-------

//ввод данных пользователем
Console.Write ("Введите размер массива: ");
int size_A = int.Parse(Console.ReadLine()!);
//ввод переменной, задание массива + вызов функции
int[] Array_1 = GetArray_1 (size_A);
int[] Array_2 = GetArray_2 (Array_1);
//вывод данных на консоль
Console.WriteLine ($"Массив: [{String.Join (", ", Array_1)}]");

Console.WriteLine ($"Новый массив: [{String.Join (", ", Array_2)}]");


// ------ МЕТОД ------
int [] GetArray_1 (int size_P)
{
    int [] number = new int [size_P];
    for (int i = 0; i < number.Length; i++)
    {
        number [i] = new Random().Next(0, 10);
    }
    return number;    
}

int [] GetArray_2 (int [] array)
{
    int [] number = new int [array.Length/2];
    for (int i = 0, g = array.Length-1; i < number.Length; i++, g--)
    {
        number [i] = array[i] * array[g];
    }
    return number;    
}

