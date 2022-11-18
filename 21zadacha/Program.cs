// координаты 2 точек в 3мерном пространстве, расстояние между ними
// a(3,6,8); b(2,1,-7) = 15,84

Console.WriteLine("Введите X точки a: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y точки a: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z точки a: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите X точки b: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y точки b: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z точки b: ");
int z2 = Convert.ToInt32(Console.ReadLine());

int resultX = x2 - x1;
int resultY = y2 - y1;
int resultZ = z2 - z1;
// double result = Math.Sqrt((resultX * resultX) + (resultY * resultY) + (resultZ * resultZ));
double result = Math.Sqrt(Math.Pow(resultX, 2) + Math.Pow(resultY, 2) + Math.Pow(resultZ, 2));
Console.WriteLine("Длина отрезка между точкой a и b = " + result);

