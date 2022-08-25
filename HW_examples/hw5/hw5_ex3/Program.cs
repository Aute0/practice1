// Задача 38: Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double [] arr = new double[10];

for (int i = 0; i < arr.Length; i++)
   {
        arr[i] = new Random().NextDouble();
        Console.Write(arr[i] + "; ");
    }

Console.WriteLine();

double min = arr[0];
double max = arr[0];
foreach (double i in arr)  // Поиск максимального и минимального значения
{
    if (min > arr[i]) min = arr[i];
    if (max < arr[i]) max = arr[i];
}
double diff = max - min;

Console.WriteLine($"\n Максимальный элемент: {max}\n Минимальный элемент: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом: " + diff);