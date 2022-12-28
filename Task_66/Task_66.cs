/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Write("Введите M: ");
int M = int.Parse(Console.ReadLine()!);

Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine()!);

Console.Write($"Значения элементов в промежутке от M ({M}) до N ({N}): ");
Console.WriteLine(PrintNumbers(M,N));

Console.WriteLine($"Сумма элементов в промежутке от M ({M}) до N ({N}) равна {PrintSumNumbers(M,N)}!");
//Console.WriteLine(PrintNumbers(M,N));

string PrintNumbers(int start, int end){
    if(start == end) return start.ToString();
    return(start + " " + PrintNumbers(start + 1, end));
}

int PrintSumNumbers(int start, int end){
    if(start == end) return start;
    return(start + PrintSumNumbers(start + 1, end));
}

