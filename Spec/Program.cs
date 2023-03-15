//Написать программу которая из имеющегося массива строк формирует
// массив из строк длина которых меньше, либо равна трём символам
Console.WriteLine("Введите желаемую строку для обработки: ");
string originalString = Console.ReadLine();
string[] enteredArray = originalString.Split(' ', 
StringSplitOptions.RemoveEmptyEntries); // Формирование массива строк 
//из введённого предложения. Разделение по пробелу 
Console.WriteLine("Исходный массив: ");
    for (int i = 0; i < enteredArray.Length; i++)
Console.Write(enteredArray[i] + " ");  // Вывод на экран введённой строки 
//в виде массива строк и без разрывов 
Console.WriteLine();
Console.WriteLine("Отсортированный массив: ");
var resultString = new string[enteredArray.Length];  // ЗАдаём новый 
//массив, куда будут записываться отсортированные значения
var size = 0;
foreach (var value in enteredArray)
{
if (value.Length <= 3)  // сортировка будет происходить по трём 
//символам, включая знаки препинания и спецсимвола, если в параметре 
//split не было указано иное
   {
    resultString[size] = value;
    Console.Write(resultString[size] + ' ');  //вывод нового массива из 
    //строк 3 и менее символов
    size++;
   }
}