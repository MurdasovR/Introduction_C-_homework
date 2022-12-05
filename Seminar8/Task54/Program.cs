// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
int rows = InputIntValue("Введите количество строк двумерного массива");
if (rows <= 0) InputError();
int columns = InputIntValue("Введите количество столбцов двумерного массива");
if (columns <= 0) InputError();
int minArray = -20;
int maxArray = 20;
int[,] array = RandomTwoDimensionalArray(rows, columns, minArray, maxArray);
Console.WriteLine("\nИсходный массив размером [{0},{1}]:", rows, columns);
WriteTwoDimensionalArray(array);
Console.WriteLine("\nСтроки массива отсортированы в порядке убывания:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns - 1; j++)
    {
        int maxIndex = j;
        for (int k = j + 1; k < columns; k++)
            if (array[i, k] > array[i, maxIndex]) maxIndex = k;
        (array[i, j], array[i, maxIndex]) = (array[i, maxIndex], array[i, j]);
    }
}
WriteTwoDimensionalArray(array);