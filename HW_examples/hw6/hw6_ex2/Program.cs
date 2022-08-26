// Задача 43: Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// 
// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

// FAQ for me:
// var используем только для double переменных!
// пересечение прямых считаем по формуле: 
//              x=-(b1-b2)/(k1-k2);
//              y=k1*x+b1;
// Math.Round - Округляет значение до ближайшего целого или указанного
//              количества десятичных знаков.


// ввод данных пользователем:

Console.WriteLine("Insert b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insert k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insert b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insert k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());

var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;

x = Math.Round(x, 2);
y = Math.Round(y, 2);

Console.WriteLine($"Lines intersect at a point: ({x};{y})");
