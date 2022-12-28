/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

// --------- ОСНОВНАЯ ПРОГРАММА ---------

int m = InputNumbers ("Введите m (m > 0): ");
int n = InputNumbers ("Введите n (n > 0): ");
Console.WriteLine();
Console.WriteLine($"А({m},{n})");
Console.WriteLine($"Значение функции Аккермана равно {FuncAckermann(m,n)}!");

// --------- МЕТОДЫ ---------

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = int.Parse(Console.ReadLine()!);
  if (output < 0) return output = output * (-1);
  return output;
}

int FuncAckermann (int m, int n)
{
  if (m == 0) return n + 1;
  else
    if ((m != 0) && (n == 0)) 
      return FuncAckermann(m - 1, 1);
    else
      return FuncAckermann(m - 1, FuncAckermann(m, n - 1));
}