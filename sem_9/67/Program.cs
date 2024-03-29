﻿//задача 67. напишите программу, которая будет принимать на вход число
// и возвращать сумму его цифр.
// 453 ->12
// 45 ->9
using System;
using static System.Console;


Clear();
Write("Введите число: ");
int m = int.Parse(ReadLine());

WriteLine($"{m}->{SumNumbers(m)}");

int SumNumbers(int number)
{
    if (number == 0)
        return 0;
    return (number % 10 + SumNumbers(number / 10));
}
