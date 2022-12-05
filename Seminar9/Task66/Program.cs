// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int IntervalSum(int numberStart, int numberFinal)
{
    if (numberStart == numberFinal) return numberStart;
    return numberFinal + IntervalSum(numberStart, numberFinal - 1);
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


int m = InputIntValue("Введите нижнюю границу интервала M");
int n = InputIntValue("Введите верхнюю границу интервала N");
if (m < n) Console.WriteLine($"M = {m}; N = {n} -> {IntervalSum(m, n)}");
else Console.WriteLine("Ошибка ввода, попробуйте еще раз");