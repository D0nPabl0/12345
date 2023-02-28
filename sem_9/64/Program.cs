//Задача 64: Задайте значение N. Напишите программу, которая выведет все 
//натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
using System;
using static System.Console;
//сделал через 2 переменные
Clear();
Write("Введите N: ");
int n=int.Parse(ReadLine());
int start = 1 ;
WriteLine(PrintNumbers(start, n));
string PrintNumbers(int start, int end)
{
if (end == start)
{
return end.ToString();
}

string s = PrintNumbers(start + 1, end) +" "+ start.ToString();
return (s);
}