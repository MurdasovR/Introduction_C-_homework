// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Write("Введите два числа через пробел: ");
string[] input = Console.ReadLine().Split(' ');
if (int.TryParse(input[0], out var a) && int.TryParse(input[1], out var b)) 
{
    if (a == b) {Console.WriteLine("Числа {0} и {1} равны", a, b);}
    else 
    {
        if (a>b) {Console.WriteLine("Максимальным из {0} и {1} является {0}", a, b);}
        else {Console.WriteLine("Максимальным из {0} и {1} является {1}", a, b);}
    }
}
else {Console.WriteLine("Ошибка ввода, попробуйте еще раз");}