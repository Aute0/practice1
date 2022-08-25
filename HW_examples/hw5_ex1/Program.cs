// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] arr = new int[5];
int k = 0;
Random rnd = new Random();

Console.WriteLine("Исходный массив");
for (int i = 0; i < 5; i++)
{
    arr[i] = rnd.Next(100, 1000);
    Console.Write("{0} ", arr[i]);
}
Console.WriteLine();

foreach (int element in arr)
{
    Console.Write("{0} ", element);
    if (element % 2 == 0)
    {
        k++;
    }
}
Console.WriteLine("\nКоличество четных элементов {0}", k);