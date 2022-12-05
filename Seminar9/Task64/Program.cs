// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string Print(int number)
{
    if (number == 1) return "1";
    return String.Format("{0}, ", number) + Print(number - 1);
}

int InputIntValue(string question)
{
    Console.Write(question + ": ");
    if (!int.TryParse(Console.ReadLine()!, out var result))
    {
        Console.WriteLine("Ошибка ввода, попробуйте еще раз");
        Environment.Exit(0);
    }
    return result;
}


int N = InputIntValue("Введите натуральное число");
if (N > 0) Console.WriteLine("N = {0} -> \"" + Print(N) + "\"", N);
else Console.WriteLine("Ошибка ввода, попробуйте еще раз");