// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.
// 1, 2, 5, 7, 19-> [1, 2, 5, 7, 19]
// 6, 1, 33-> [6, 1, 33]



    int[] array = new int[10];
    Random my_array = new Random();

    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = my_array.Next(0, 10);
        Console.Write("{0} ", array[i]);
    }

