﻿//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int twoDigit = 0;

if (number > 99 && number < 1000)
{
    twoDigit = (number - (number / 100) * 100) / 10;
    Console.WriteLine($"Вторая цифра числа {number} = {twoDigit}");
}
else if (number < -99 && number > -1000)
{
    number = number * -1;
    twoDigit = (number - (number / 100) * 100) / 10;
    Console.WriteLine($"Вторая цифра числа {number} = {twoDigit}");
}
else
    Console.WriteLine("Число не трёхзначное!");
