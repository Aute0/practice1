// create method for print array


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

void MultiplyMatrix(int[,] ArrayFirst, int[,] ArraySecond, int[,] MultiplyResult)
{
    for (int i = 0; i < MultiplyResult.GetLength(0); i++)
    {
        for (int j = 0; j < MultiplyResult.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < ArrayFirst.GetLength(1); k++)
            {
                sum += ArrayFirst[i, k] * ArraySecond[k, j];
            }
            MultiplyResult[i, j] = sum;
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