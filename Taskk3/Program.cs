// Программа, которая на вход принимает координаты дух точек, и находит
// расстояние между точками в 2D пространстве!

Console.WriteLine("Введите координаты точки (x1, y1)");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки (x2, y2)");
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

Console.WriteLine($"Расстояние между точками равно: {result}");