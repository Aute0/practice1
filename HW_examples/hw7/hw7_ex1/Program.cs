// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 - 2 - 0,2
// 1 - 3,3 8 - 9,9
// 8 7,8 - 7,1 9

// FAQ for me: 
// NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
// {0,6:F2} - округление - знаки после запятой

Console.WriteLine("Введите размеры массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double[,] a = new double[m, n];

Random random = new Random();
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        a[i, j] = random.NextDouble() * 100; 
        Console.Write("{0,6:F2}", a[i, j]);
    }
    Console.WriteLine();
}


