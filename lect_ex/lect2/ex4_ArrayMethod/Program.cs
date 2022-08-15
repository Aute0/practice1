// Array Method

int [] array = new int[10]; //  по умолчанию массив из 10 нулевых эл-ов

void FillArray(int[] collection) // метод заполнения нулевого массива
{
    int length = collection.Length; // длину получим из collection
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); //заполняем на каждом шаге коллекцию целыми числами от 1 до 10
        index++;

    }
}

void PrintArray(int[] collection1) // метод, который делает-не возвращает результат
{

    int count = collection1.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(collection1[position]);
        position++;
    }
    
}

FillArray(array);
PrintArray(array);





