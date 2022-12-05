// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int FunctionAckermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if ((m != 0) && (n == 0)) return FunctionAckermann(m - 1, 1);
    else return FunctionAckermann(m - 1, FunctionAckermann(m, n - 1));
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


int m = InputIntValue("Введите неотрицательное целое число m");
int n = InputIntValue("Введите неотрицательное целое число n");
if (m >= 0 && n >= 0) Console.WriteLine($"m = {m}, n = {n} -> A({m},{n}) = {FunctionAckermann(m, n)}");
else Console.WriteLine("Ошибка ввода, попробуйте еще раз");