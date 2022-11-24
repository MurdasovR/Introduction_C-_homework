// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2 3 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Write("Введите три целых числа через пробел: ");
string[] input = Console.ReadLine().Split();
int[] a = new int[3];
for (int i=0; i < 3; i++)
{
    if (!(int.TryParse(input[i], out var num)))
    {Console.WriteLine("Ошибка ввода, попробуйте еще раз");
    Environment.Exit(0);}
    else {a[i] = num;}
}
Console.WriteLine("Максимальным из {0} является {1}", String.Join(" и ", a), a.Max());