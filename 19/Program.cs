// Напишите программу, которая принимает на вход пятизначное 
//число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();
Console.WriteLine("Vvedite pyatiznachnoe chislo: ");
string number = Console.ReadLine();
int palindrom = number.Length;
if (palindrom == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Palindrom");
    }
    else
    {
        Console.WriteLine($"{number} - Ne palindrom");
    }
}
else
{
    Console.WriteLine($"{number} - nepravilnoe chislo");
}

