// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0


int[] arr = new int[5];
int k = 0; 
int sum = 0;
Random rnd = new Random();

Console.WriteLine("Исходный массив");
for (int i = 0; i < 5; i++)
{
    arr[i] = rnd.Next(-10, 10);
    Console.Write("{0} ", arr[i]);
}
Console.WriteLine();

foreach (int element in arr)
{
    Console.Write("{0} ", element);
    if (element % 2 != 0)
    {
        k++;
        sum += element;
    }
}
Console.WriteLine("\nКоличество нечетных элементов: " + k);
Console.WriteLine("\nСумма нечетных элементов: " + sum);


