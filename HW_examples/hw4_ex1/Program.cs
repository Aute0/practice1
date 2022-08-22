// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5-> 243(3⁵)
// 2, 4-> 16

Console.WriteLine("Number A(base): ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Number B(power): ");
int numB = Convert.ToInt32(Console.ReadLine());

int degAB(int numA, int numB)
{
    int res = 1;
    for (int i = 1; i <= numB; i++)
    {
        res = res * numA;
    }
    return res;
}

int degree = degAB(numA, numB);
Console.WriteLine("number A power B : " + degree);