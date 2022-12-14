//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int SummElemInLine(int[,] array, int i)
{
    int SummElemInLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        SummElemInLine += array[i, j];
    }
    return SummElemInLine;
}
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine($"\nВведите размер массива:");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int[,] InitialArray = new int[m, n];
CreateArray(InitialArray);
WriteArray(InitialArray);

int MinSumInLine = 0;
int SumInLine = SummElemInLine(InitialArray, 0);
for (int i = 1; i < InitialArray.GetLength(0); i++)
{
    int tempSumLine = SummElemInLine(InitialArray, i);
    if (SumInLine > tempSumLine)
    {
        SumInLine = tempSumLine;
        MinSumInLine = i;
    }
}

Console.WriteLine($"\n{MinSumInLine + 1} - строкa с наименьшей суммой элементов ({SumInLine})  ");