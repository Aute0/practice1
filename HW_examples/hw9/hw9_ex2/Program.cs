// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N.
// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

int M = InputNumbers("Введите M: ");
int N = InputNumbers("Введите N: ");

int SummRoutine(int M, int N)
{
    int FirstElement = M;
    int LastElement = N;
    if (M > N)
    {
        FirstElement = N;
        LastElement = M;
    }
    return (LastElement + FirstElement) * (LastElement - FirstElement + 1) / 2; // по формуле суммы членов арифметической прогрессии
}

Console.WriteLine(SummRoutine(M, N));

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}