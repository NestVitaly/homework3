//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите  три точки координаты А: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());   //Координаты первой точки
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  три точки координаты В: ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());   //Координаты второй точки
int z2 = Convert.ToInt32(Console.ReadLine());
double distance (int x1, int y1, int z1, int x2, int y2, int z2)
    {
        int resultX = (x2 - x1) * (x2 - x1);
        int resulty = (y2 - y1) * (y2 - y1);
        int resultz = (z2 - z1) * (z2 - z1);
        double XYZ = Math.Sqrt(resultX + resulty + resultz);
        return (XYZ);
    }
Console.WriteLine("Расстояние между точками: "+distance (x1, y1, z1, x2, y2, z2));