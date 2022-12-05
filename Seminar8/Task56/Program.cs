// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void WriteTwoDimensionalArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0, 5}", array[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] RandomTwoDimensionalArray(int row, int col, int minValue, int maxValue)
{
    int[,] result = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

int InputIntValue(string question)
{
    Console.Write(question + ": ");
    if (!int.TryParse(Console.ReadLine()!, out var result)) InputError();
    return result;
}

void InputError()
{
    Console.WriteLine("Ошибка ввода, попробуйте еще раз");
    Environment.Exit(0);
}


Console.Clear();
int size = InputIntValue("Введите размер N квадратного массива");
if (size <= 0) InputError();
int minArray = -20;
int maxArray = 20;
int[,] array = RandomTwoDimensionalArray(size, size, minArray, maxArray);
Console.WriteLine("\nСлучайный массив размером [{0},{1}]:", size, size);
WriteTwoDimensionalArray(array);
int minSum = 0;
for (int j = 0; j < size; j++)
    minSum += array[0, j];
int minRow = 0;
Console.WriteLine("строка {0}, сумма = {1,5}", 0, minSum);
for (int i = 1; i < size; i++)
{
    int sumCurrent = 0;
    for (int j = 0; j < size; j++)
    {
        sumCurrent += array[i, j];
    }
    if (sumCurrent < minSum) { minSum = sumCurrent; minRow = i; }
    Console.WriteLine("строка {0}, сумма = {1,5}", i, sumCurrent);
}
Console.WriteLine("Строка с минимальной суммой элементов -> {0}, сумма = {1,5}", minRow, minSum);