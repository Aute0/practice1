// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Нужно сделать через числа, без индексов строк.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Your number: ");

int num = Convert.ToInt32(Console.ReadLine());

int num1 = num % 100;
int num2 = num1 / 10;

Console.WriteLine($"Second number from {num} is: {num2} ");
