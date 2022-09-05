﻿// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные
// числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

int M = InputNumbers("Введите M: ");
int N = InputNumbers("Введите N: ");

Console.WriteLine($"N={N}, M={M}");
    if (M > N)
        for (int i = N; i <= M; i++)
            Console.Write($" {i}");
    else
        for (int i = M; i <= N; i++)
            Console.Write($" {i}");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

