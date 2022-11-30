// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumOfDigits(int Number)
{
    int result = 0;
    while (Number > 0)
    {
        result += Number % 10;
        Number /= 10;
    }
    return result;
}
Console.Write("Введите целое число N > 0: ");
if (int.TryParse(Console.ReadLine(), out int N) && N > 0)
{
    Console.WriteLine("Сумма цифр числа {0} равна {1}", N, SumOfDigits(N));
}
else
{
    Console.WriteLine("Ошибка ввода, попробуйте еще раз");
}