﻿Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

if (a > b) Console.WriteLine($"{a} > {b}");
else Console.WriteLine($"{b} > {a}");