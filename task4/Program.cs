﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

System.Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

for (int i = 0; i < number; i++)
{
    if (i % 2 == 0)
    {
        System.Console.WriteLine(i + " ");
    }
}
