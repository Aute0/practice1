// Задача:
// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Массив можно ввести с клавиатуры, либо
// задать на старте алгоритма.


string[] ArrayFirst = new string[6] { "2h", "p", "59830", "23df", "res", "sonya"};
string[] ArrayWork = new string[ArrayFirst.Length];
void ArraySolution(string[] ArrayFirst, string[] ArrayWork)
{
    int count = 0;
    for (int i = 0; i < ArrayFirst.Length; i++)
    {
        if (ArrayFirst[i].Length <= 3)
        {
            ArrayWork[count] = ArrayFirst[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ArraySolution(ArrayFirst, ArrayWork);
PrintArray(ArrayWork);
