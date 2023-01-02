// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// ● A (3,6); B (2,1) -> 5,09
// ● A (7,-5); B (1,-1) -> 7,21

double DistancBetweenPoints(int x1, int y1, int x2, int y2)
{
    double distanc = Math.Sqrt((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1));
    return distanc;
}

int[] pointA = new int[2];
int[] pointB = new int[2];

Console.Write("Введите кординаты первой точки - ");
pointA[0] = int.Parse(Console.ReadLine());
pointA[1] = int.Parse(Console.ReadLine());

Console.Write("Введите кординаты второй точки - ");
pointB[0] = int.Parse(Console.ReadLine());
pointB[1] = int.Parse(Console.ReadLine());

Console.WriteLine(DistancBetweenPoints(pointA[0], pointA[1], pointB[0], pointB[1]));
