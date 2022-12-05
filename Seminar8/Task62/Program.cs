// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[] InputIntTwinArray(string question)
{
    Console.Write(question + ": ");
    string[] input = Console.ReadLine()!.Split();
    if (input.Length != 2) InputError();
    int[] inputInt = new int[2];
    if (int.TryParse(input[0], out var n0) && int.TryParse(input[1], out var n1))
    {
        inputInt[0] = n0;
        inputInt[1] = n1;
    }
    else InputError();
    return inputInt;
}

void InputError()
{
    Console.WriteLine("Ошибка ввода, попробуйте еще раз");
    Environment.Exit(0);
}

void Write2DArray(int[,] array)
{
    int numberOfSigns = (int)Math.Log10(array.GetLength(0) * array.GetLength(1)) + 1;
    if (numberOfSigns < 2) numberOfSigns = 2;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j].ToString(String.Format("D{0}", numberOfSigns)) + " ");
        }
        Console.WriteLine();
    }
}


int[,] SpiralFillingArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    int i = 0;
    int j = 0;
    int di = 0;
    int dj = 1;
    for (int number = 1; number <= rows * columns; number++)
    {
        if ((dj == 1 && j == columns - 1 - i) || (di == 1 && i == rows + j - columns) || (dj == -1 && j == rows - i - 1) || (di == -1 && i == j + 1))
            (di, dj) = (dj, -di);
        result[i, j] = number;
        i += di;
        j += dj;
    }
    return result;
}


Console.Clear();
int[] size = InputIntTwinArray("Введите через пробел количество строк и столбцов массива");
if (size[0] <= 0 || size[1] <= 0) InputError();
int[,] array = SpiralFillingArray(size[0], size[1]);
Console.WriteLine("\nМассив размером {0} x {1}, заполненный по спирали:", size[0], size[1]);
Write2DArray(array);