// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double NaturalPowerOfA(double numberA, int naturalPower)
{
    double result = 1;
    for (int i = 1; i <= naturalPower; i++)
    {
        result *= numberA;
    }
    return result;
}

double NaturalPowerRecursion(double numberA, int naturalPower)
{
    if (naturalPower == 0) {return (double)1;}
    else {return NaturalPowerRecursion(numberA,naturalPower-1)*numberA;}
}

void InputError()
{
    Console.WriteLine("Ошибка ввода, попробуйте еще раз");
}

Console.Write("Введите основание степени: ");
string input = Console.ReadLine();
if (input.IndexOf('.') != -1)
{
    input = input.Replace('.', ',');
}
if (double.TryParse(input, out var inputNumber))
{
    Console.Write("Натуральный показатель степени: ");
    if (int.TryParse(Console.ReadLine(), out var N) && N >= 0)
    {
        Console.WriteLine("{0} в степени {1} равно {2} или {3}", inputNumber, N, NaturalPowerOfA(inputNumber, N), NaturalPowerRecursion(inputNumber, N));
    }
    else { InputError(); }
}
else { InputError(); }