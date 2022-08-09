// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
//a = 5; b = 7->max = 7
//a = 2 b = 10->max = 10
//a = -9 b = -3->max = -3

// Console.WriteLine("Введите число номер 1: ");
// double num1 = Console.ReadLine();
// Console.WriteLine("Введите число номер 2: ");
// double num2 = Console.ReadLine();

int a=-9;
int b=-3;
int max=0;
int min=0;

if (a > b)
        {
            max = a; min = b;}   
else    {
            max = b; min = a;}

Console.WriteLine("max= " + max);
Console.WriteLine("min= " + min);