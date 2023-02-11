// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
Console.Write("Введите первое число A: ");
int N = int.Parse(Console.ReadLine());
Console.Write("Введите второе число B: ");
int i = int.Parse(Console.ReadLine());
Console.WriteLine($"Ответ: {Math.Pow(N, i)} ");
