//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//
//456 -> 5
//782 -> 8
//918 -> 1
Console.WriteLine("Введите трехзначное число");

int a = Convert.ToInt32(Console.ReadLine());


if (99 < a && a < 1000) ;
{
    int b = a / 10;
    int c = b % 10;
    Console.WriteLine(c);
}
//else
//{
//Console.WriteLine("Ошибка! Введите трехзначное число"); //	"message": "\"else\" не может запускать оператор. [OmniSharpMiscellaneousFiles.csproj]",
//}
