// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
double SquareDiff (double x2, double x1) 
{
    return (x2 - x1) * (x2 - x1);
}

Console.Write("Введите координаты первой точки (x,y,z) через пробел: ");
string[] input1 = Console.ReadLine().Split();
Console.Write("Введите координаты второй точки (x,y,z) через пробел: ");
string[] input2 = Console.ReadLine().Split();
double[] a = new double[3];
double[] b = new double[3];
double Distance = 0;
for (int i=0; i < 3; i++)
{
    if (input1[i].IndexOf('.') != -1) {input1[i] = input1[i].Replace('.', ',');}
    if (input2[i].IndexOf('.') != -1) {input2[i] = input2[i].Replace('.', ',');}
    if (!(double.TryParse(input1[i], out var na) && double.TryParse(input2[i], out var nb))) {Console.WriteLine("Ошибка ввода, попробуйте еще раз"); Environment.Exit(0);}
    else {a[i] = na; b[i] = nb; Distance = Distance + SquareDiff(nb, na);}
}
Distance = Math.Sqrt(Distance);
Console.WriteLine("Расстояние между точкими ({0}) и ({1}) равно {2:f2}", String.Join(" ; ", a), String.Join(" ; ", b), Distance);