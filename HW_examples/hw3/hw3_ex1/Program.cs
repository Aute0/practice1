// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Твое число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine((num == 0) || (reverse(num, 0) == num));
Console.ReadKey(true);

int reverse(int num, int mun)
{
    while (num > 0) { mun = mun * 10 + num % 10; num /= 10; }
    return mun;
}
