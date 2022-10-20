//Дополнительная Задача 9
//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет
//46 -> нет
//161 -> да

int a = 80;

if (a % 7 == 0 && a % 23 == 0)
{
    System.Console.Write("Число ");
    System.Console.Write(a);
    System.Console.WriteLine(" кратно одновременно 7 и 23.");
}

else
{
    System.Console.Write("Число ");
    System.Console.Write(a);
    System.Console.WriteLine(" не кратно одновременно 7 и 23.");
}