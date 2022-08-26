// Задача 42: Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 45-> 101101
// 3-> 11
// 2-> 10

// FAQ for me:
// Convert.ToString(<десятичное число>, <основание системы счисления>) 
//                  - переводит ТОЛЬКО в 2 и 8 системы
// Можно еще чисто математически делением:
/*
{
    uint n, x;
    do Console.Write("Число:");
    while (!uint.TryParse(Console.ReadLine(), out n));
    x = n;
    for (uint i = 2; i < 10; i++, x = n)
    {
        string s = n == 0 ? "0" : "";
        while (x > 0)
        {
            s = x % i + s;
            x /= i;
        }
        Console.WriteLine("{0}-я:{1}", i, s);
    }
    Console.ReadKey();
}
*/
// int.Parse        - в данном случае помогает решить ошибку int to string


Console.WriteLine("Insert your number (10 system): ");
int x = int.Parse(Console.ReadLine());

string bin = Convert.ToString(x, 2);

Console.WriteLine("Your number in 2 system is: " + bin); 
