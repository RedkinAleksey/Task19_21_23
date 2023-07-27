﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.Write("Введите натуральное число число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
{
    Console.WriteLine("Некорректные данные");
}

SquareNumber(number);

void SquareNumber(int numb)
{
    int count = 1;
    while(count <= numb)
    {
        Console.WriteLine($"{count, 3}       {count * count * count, 5}");
        count++;
    }
}