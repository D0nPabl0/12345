// Задача 27: Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
Console.Write("Введите число : ");
int num = int.Parse(Console.ReadLine());
int num1 = num;//num = 12345
int a1 = num / 10000; // num / 10000 = 1
num = num - (a1 * 10000); // 12345 - (1 * 10000) = 2345 <=> num = num % 10000 (2345)
int a2 = num / 1000; // 2345 / 1000 = 2
num -= a2 * 1000; // num = 345
int a3 = num / 100; // 345 / 100 = 3
num -= a3 * 100; // num = 45
int a4 = num / 10; // a4 = 45 / 10 = 4
int a5 = num % 10; // a5 = 5 = 45 % 5
Console.WriteLine($"{a1 + a2 + a3 + a4 + a5} : ");
