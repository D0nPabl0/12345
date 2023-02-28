//задача 65: задайте значения М и Н. Напишите программу, которая выведет все
// натуральные числа в промежутке от М до Н
using System;
using static System.Console;

Clear();
Write("Введите M: ");
int m=int.Parse(ReadLine());
Write("Введите N: ");
int n=int.Parse(ReadLine());
WriteLine(PrintNumbers(n, m));
string PrintNumbers(int end, int start)
{
if (end == start)
{
return start.ToString();
}

string s = PrintNumbers(end - 1, start) +" "+ end.ToString();
return (s);
}