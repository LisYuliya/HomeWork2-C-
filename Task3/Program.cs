﻿//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите число и узнайте какой это будет день недели");

int a = Convert.ToInt32(Console.ReadLine());

//int a = 817;
if (a <= 0)
{
    do
    {
        System.Console.WriteLine("Не бывает отрицательных и нулевых дней, это все настроение.");
        System.Console.WriteLine("Надо выпить вкусный кофе и все пройдет:)");
        System.Console.WriteLine("А пока надо ввести положительное число :)");
        a = Convert.ToInt32(Console.ReadLine());
    }
    while (a <= 0);
}
if (a > 7) a = a - (7 * (a / 7));

if (a == 1) System.Console.WriteLine("Это будет понедельник - рабочий день");
if (a == 2) System.Console.WriteLine("Это будет вторник - рабочий день");
if (a == 3) System.Console.WriteLine("Это будет среда - рабочий день");
if (a == 4) System.Console.WriteLine("Это будет четверг - рабочий день");
if (a == 5) System.Console.WriteLine("Это будет пятница - рабочий день, но уже скоро выходные :)");
if (a == 6) System.Console.WriteLine("Это будет суббота - выходной день");
if (a == 7) System.Console.WriteLine("Это будет воскресенье - выходной день");
