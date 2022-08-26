// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь

// FAQ for me: 
// Split            - делит пробелы.
// int.Parse        - Преобразует строковое представление числа в эквивалентное
//                    ему 32-битовое целое число со знаком
// Array.ConvertAll - метод преобразования массива одного типа в другой.
//                  - преобразование массива строк в массив целых чисел.

Console.Write("Insert your numbers (use space, pls): ");  // ввод чисел
int[] user_arr = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);  

int count = 0;                                            // запуск счетчика

for (int i = 0; i < user_arr.Length; i++)
{
    if (user_arr[i] > 0)
    {
        count++;
    }
}

Console.WriteLine($"Number of positive values: " + count);