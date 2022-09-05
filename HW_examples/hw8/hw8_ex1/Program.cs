// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
//                          1 4 7 2
//                          5 9 2 3
//                          8 4 2 4
// В итоге получается вот такой массив:
//                          7 4 2 1
//                          9 5 3 2
//                          8 4 4 2

//FAQ for me:
// void запихиваем туда подпрограммы. Очень удобно, уменьшает количество строк.
// Страшно, когда нужно менять имя переменной.
// InputNumber - подпрограмма ввода с консоли. Просто симпатичнее, чем обычно.
// FillArray  - подпрограмма заполнения изначально нулевого массива, по примеру с лекции, немного доработана
// ArrayOrder - собственно определяет нужный порядок - сортировка

Console.WriteLine($"\nВведите размер массива: ");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int[,] InitialArray = new int[m, n];

Console.WriteLine($"\nНачальный массив: ");

FillArray(InitialArray);
WriteArray(InitialArray);

void WriteArray(int[,] arrInitialArrayay)
{
    for (int i = 0; i < InitialArray.GetLength(0); i++)
    {
        for (int j = 0; j < InitialArray.GetLength(1); j++)
        {
            Console.Write(InitialArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] InitialArray)
{
    for (int rows = 0; rows < InitialArray.GetLength(0); rows++)
    {
        for (int columns = 0; columns < InitialArray.GetLength(1); columns++)
        {
            InitialArray[rows, columns] = new Random().Next(1, 10);
        }
            }
}
void ArrayOrder(int[,] InitialArray)
{
    for (int i = 0; i < InitialArray.GetLength(0); i++)
    {
        for (int j = 0; j < InitialArray.GetLength(1); j++)
        {
            for (int k = 0; k < InitialArray.GetLength(1) - 1; k++)
            {
                if (InitialArray[i, k] < InitialArray[i, k + 1])
                {
                    int temp = InitialArray[i, k + 1];
                    InitialArray[i, k + 1] = InitialArray[i, k];
                    InitialArray[i, k] = temp;
                }
            }
        }
    }
}

Console.WriteLine($"\nОтсортированный массив: ");
ArrayOrder(InitialArray);
WriteArray(InitialArray);