/* Задача 38: Задайте массив целых чисел от -10 до 10. 
Найдите разницу между максимальным и минимальным элементов массива.*/

//------ОСНОВНАЯ ПРОГРАММА-------

//ввод данных пользователем
Console.Write ("Введите размер массива: ");
int size_A = int.Parse(Console.ReadLine()!);
//ввод переменной, задание массива + вызов функции
int[] Array = GetArray (size_A);

//вывод данных на консоль
Console.WriteLine ($"Массив: [{String.Join (", ", Array)}]");

int min = int.MaxValue;
int max = int.MinValue;

foreach(int el in Array)
{
    if (el > max)
        {
            max = el;
        }
    if (el < min)
        {
            min = el;
        }
}


if (min>0)
{
    Console.WriteLine($"Всего {size_A} чисел. Максимальное значение = {max}, минимальное значение = {min}");
    Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
}
else
{
    Console.WriteLine($"Всего {size_A} чисел. Максимальное значение = {max}, минимальное значение = {min}");
    Console.WriteLine($"Разница между максимальным и минимальным значением = {max -(-min)}");
}
// ------ МЕТОД ------
int [] GetArray (int size_P)
{
    int [] number = new int [size_P];
    for (int i = 0; i < number.Length; i++)
    {
        number [i] = new Random().Next(-11, 11);
    }
    return number;    
}
