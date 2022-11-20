Random rand = new Random();
double x1 = rand.Next(-100, 100);
double y1 = rand.Next(-100, 100);
double z1 = rand.Next(-100, 100);

double x2 = rand.Next(-100, 100);
double y2 = rand.Next(-100, 100);
double z2 = rand.Next(-100, 100);
Console.Write("Координаты точки A: " + $"A({x1}, {y1}, {z1})");
Console.Write("\nКоординаты точки B: " + $"B({x2}, {y2}, {z2})");
Console.WriteLine("\n----------------------------------------------------");
double distance = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
Console.Write("Расстояние между двумя точками в пространстве равно: " + distance);