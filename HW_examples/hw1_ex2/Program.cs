// Задача 4: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел
// 2, 3, 7-> 7
// 44 5 78-> 78
// 22 3 9-> 22

Console.WriteLine("First number:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Second number:");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Third number:");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (num1 >= num2)
{
    max = num1;
}
else
{
    max = num2;
}
if (max >= num3)
{
    Console.WriteLine("max of three numbers: " + max);
}
else
{
    max = num3;
    Console.WriteLine("max of three numbers: " + max);
}