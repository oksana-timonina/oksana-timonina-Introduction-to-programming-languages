/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

Console.Write ("Введите число (A): ");
int A = int.Parse (Console.ReadLine()!); // ввод переменной A (число)

Console.Write ("Введите число (B, где B>0): ");
int B = int.Parse (Console.ReadLine()!); // ввод переменной B (степень)

Console.WriteLine ($"Число {A}, возведенное в степень {B}, равно {GetPow(A,B)}"); // вызов метода

//-------МЕТОД--------

int GetPow(int num, int n)
{
	int result = num;
	for (int i = 1; i < n; i++)
	{
		result *= num;
	}
	return result;
}
