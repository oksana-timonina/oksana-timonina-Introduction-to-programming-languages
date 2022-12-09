/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7) -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

*/

/*
int [] array_A = {3,6,8};
int [] array_B = {2,1,-7};
double distance = Math.Sqrt(Math.Pow(array_B [0] - array_A [0], 2) + Math.Pow(array_B [1] - array_A [1], 2) + Math.Pow(array_B [2] - array_A [2], 2));
Console.WriteLine($"Расстояние между тремя точками в 3D пространстве равно {Math.Round(distance, 2)}");
*/

Console.Write ("Введите число (1 или 2): ");
int number = int.Parse(Console.ReadLine()!);
if (number == 1)
{
    Console.WriteLine ("A (3,6,8); B (2,1,-7)");
    int [] array_A1 = {3,6,8};
    int [] array_B1 = {2,1,-7};
    double distance1 = Math.Sqrt(Math.Pow(array_B1 [0] - array_A1 [0], 2) + Math.Pow(array_B1 [1] - array_A1 [1], 2) + Math.Pow(array_B1 [2] - array_A1 [2], 2));
    Console.WriteLine($"Расстояние между тремя точками в 3D пространстве равно {Math.Round(distance1, 2)}");

}
else
{
    Console.WriteLine ("A (7,-5, 0); B (1,-1,9)");
    int [] array_A2 = {7,-5, 0};
    int [] array_B2 = {1,-1,9};
    double distance2 = Math.Sqrt(Math.Pow(array_B2 [0] - array_A2 [0], 2) + Math.Pow(array_B2 [1] - array_A2 [1], 2) + Math.Pow(array_B2 [2] - array_A2 [2], 2));
    Console.WriteLine($"Расстояние между тремя точками в 3D пространстве равно {Math.Round(distance2, 2)}");
}