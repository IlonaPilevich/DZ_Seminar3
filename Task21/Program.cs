// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

Console.Write("Введите координату точки по оси X: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату точки по оси Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату точки по оси Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату точки по оси X: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату точки по оси Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату точки по оси Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

var result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine(Math.Round(result, 3));