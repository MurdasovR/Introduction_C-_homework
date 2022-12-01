// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int InputIntValue(string question)
{
    Console.Write(question + ": ");
    if (!int.TryParse(Console.ReadLine()!, out var N)) InputError();
    return N;
}

double InputDoubleValue(string question)
{
    Console.Write(question + ": ");
    string input = Console.ReadLine()!;
    if (input.IndexOf('.') != -1) input = input.Replace('.', ',');
    if (!double.TryParse(input, out var N)) InputError();
    return N;
}

double[] GetRandomArray(int amount, double minValue, double maxValue, int decimalPoint)
{
    double[] array = new double[amount];
    for (int i = 0; i < amount; i++)
    {
        array[i] = Math.Round(minValue + new Random().NextDouble()*(maxValue-minValue), decimalPoint);
    }
    return array;
}

string WriteDoubleArray (double[] array, int decimalPoint)
{
    string result = "[";
    for (int i = 0; i < array.Length-1; i++) result += array[i].ToString(String.Format("F{0}", decimalPoint)) + " ; ";
    return result += array[array.Length-1].ToString(String.Format("F{0}", decimalPoint)) + "]";
}

void InputError()
{
    Console.WriteLine("Ошибка ввода, попробуйте еще раз");
    Environment.Exit(0);
}

int N = InputIntValue("Введите количество элементов массива");
if (N <= 0) InputError();
double minA = InputDoubleValue("Введите min границу массива");
double maxA = InputDoubleValue("Введите max границу массива");
if (minA > maxA) InputError();
int precision = InputIntValue("Введите число десятичных знаков");
if (precision < 0) InputError();
double[] massiv = GetRandomArray(N, minA, maxA, precision);
Console.WriteLine("Массив {0}", WriteDoubleArray(massiv, precision));
minA = massiv.Min();
maxA = massiv.Max();
Console.WriteLine("Max элемент = " + maxA.ToString(String.Format("F{0}", precision)) + "; Min элемент = " + minA.ToString(String.Format("F{0}", precision)));
Console.WriteLine("Размах (Max - Min) = " + (maxA - minA).ToString(String.Format("F{0}", precision)));