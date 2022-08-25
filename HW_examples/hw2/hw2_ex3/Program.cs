// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6->да
// 7->да
// 1->нет

Console.WriteLine("Insert day of the week (number): ");
int dayOfW = Convert.ToInt32(Console.ReadLine());
if (dayOfW == 7 || dayOfW == 6)
{

    System.Console.WriteLine("Its weekend!! Congrads!");
}
else
{
    System.Console.WriteLine("Sorry, this is not weekend :(");
}
