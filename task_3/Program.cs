﻿// Задача 3: Напишите программу, которая на вход
// принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).

Console.Write("Введите число для проверки, чётное ли оно?: ");
int num = int.Parse(Console.ReadLine());
if(num % 2 == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}