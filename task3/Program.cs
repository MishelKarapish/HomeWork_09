﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите любое число: ");
int num1 = int.Parse(Console.ReadLine());
int a = Convert.ToInt32(num1);

if (a%2==0)
{
    Console.WriteLine("Введенное число является четным");
}
else
{
    Console.WriteLine("Введенное число НЕ является четным");
}