/* Задача 43: Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)
в промежутке от 0 до 100, а на выходе выводит этот же массив, но отсортированный по возрастанию
(от меньшего числа к большему).*/

//------ОСНОВНАЯ ПРОГРАММА-------


//ввод данных пользователем
Console.Write ("Введите размер массива (не меньше 6): ");
int len_a = int.Parse(Console.ReadLine()!);

if (len_a < 6)
{
    Console.WriteLine ("Размер массива не может быть меньше 6!");
    Console.WriteLine ("Введите другое число, пожалуйста :)");
}

else
{
int[] Array = GetArray (len_a);

//вывод данных на консоль
Console.WriteLine ($"Исходный массив: [{String.Join (", ", Array)}]");
SelectionSort(Array);
Console.WriteLine ($"Отсортированный массив: [{String.Join (", ", Array)}]");


// ------ МЕТОДЫ ------

int [] GetArray (int len_p)
{
    int [] number = new int [len_p];
    for (int i = 0; i < number.Length; i++)
    {
        number [i] = new Random().Next(-1, 101);
    }
    return number;    
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
}