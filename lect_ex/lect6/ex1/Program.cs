// Разворот массива

int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];          // задаем массив с заданием размера от пользователя

for ( int i = 0; i < size; i++)
{
    arr[i] = new Random().Next(11); // (0-->10)
    Console.Write(arr[i] + "\t");   // (\t---> tab)
}
