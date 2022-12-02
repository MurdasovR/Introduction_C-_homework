// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int InputIntValue(string question)
{
    Console.Write(question + ": ");
    if (!int.TryParse(Console.ReadLine()!, out var result)) InputError();
    return result;
}

double[,] RandomTwoDimensionalArray(int row, int col, double minValue, double maxValue, int decimalPoint)
{
    double[,] result = new double[row, col];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = Math.Round(minValue + new Random().NextDouble() * (maxValue - minValue), decimalPoint);
        }
    }
    return result;
}

void WriteTwoDimensionalArray(double[,] array, int decimalPoint)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0, 8}", array[i, j].ToString(String.Format("F{0}", decimalPoint)));
        }
        Console.WriteLine();
    }
}

void InputError()
{
    Console.WriteLine("Ошибка ввода, попробуйте еще раз");
    Environment.Exit(0);
}

int rows = InputIntValue("Введите количество строк двумерного массива");
if (rows <= 0) InputError();
int columns = InputIntValue("Введите количество столбцов двумерного массива");
if (columns <= 0) InputError();
double massivMin = (double)-10;
double massivMax = (double)10;
int precision = 3;
double[,] massiv = RandomTwoDimensionalArray(rows, columns, massivMin, massivMax, precision);
WriteTwoDimensionalArray(massiv, precision);