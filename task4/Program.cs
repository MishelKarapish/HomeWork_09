﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
string inputN = Console.ReadLine();
int n = Convert.ToInt32(inputN);
int a = 2;
while(a <= n)
{
    if (a % 2 == 0)
    {
        Console.Write(a + " ");
    }
a++;
}