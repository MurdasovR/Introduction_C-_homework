// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void WriteProductOfArray(int[,] array1, int[,] array2, int[,] array3)
{
    int maxRow = (array1.GetLength(0) > array2.GetLength(0)) ? array1.GetLength(0) : array2.GetLength(0);
    int maxCol = (array1.GetLength(1) > array2.GetLength(1)) ? array1.GetLength(1) : array2.GetLength(1);
    int minRow = (array1.GetLength(0) > array2.GetLength(0)) ? array2.GetLength(0) : array1.GetLength(0);
    int charPosition = (minRow + 1) / 2 - 1;
    Console.WriteLine("\nПроизведение случайных массивов размерами {0}х{1} и {2}х{3}:", array1.GetLength(0), array1.GetLength(1), array2.GetLength(0), array2.GetLength(1));
    for (int i = 0; i < maxRow; i++)
    {
        string string1 = (i < array1.GetLength(0)) ? "|" : " ";
        string string2 = (i < array2.GetLength(0)) ? "|" : " ";
        string string3 = (i < array3.GetLength(0)) ? "|" : " ";
        for (int j = 0; j < maxCol; j++)
        {
            if (i < array1.GetLength(0) && j < array1.GetLength(1)) string1 += String.Format("{0,5}", array1[i, j]);
            else if (j < array1.GetLength(1)) string1 += "     ";
            if (i < array2.GetLength(0) && j < array2.GetLength(1)) string2 += String.Format("{0,5}", array2[i, j]);
            else if (j < array2.GetLength(1)) string2 += "     ";
            if (i < array3.GetLength(0) && j < array3.GetLength(1)) string3 += String.Format("{0,7}", array3[i, j]);
        }
        if (i == charPosition)
        {
            string1 += " |     x     ";
            string2 += " |     =     ";
        }
        else
        {
            string1 += (i < array1.GetLength(0)) ? " |           " : "             ";
            string2 += (i < array2.GetLength(0)) ? " |           " : "             ";
        }
        string3 += (i < array3.GetLength(0)) ? " |" : "";
        Console.WriteLine(string1 + string2 + string3);
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

bool ArrayCoherence(int[] size1, int[] size2)
{
    if (size1[1] == size2[0]) return true;
    else return false;
}

int[,] ProductOfArray(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
                result[i, j] += array1[i, k] * array2[k, j];
        }
    }
    return result;
}

Console.Clear();
int[] size1 = InputIntTwinArray("Введите через пробел количество строк и столбцов 1-го массива");
if (size1[0] <= 0 || size1[1] <= 0) InputError();
int[] size2 = InputIntTwinArray("Введите через пробел количество строк и столбцов 2-го массива");
if (size2[0] <= 0 || size2[1] <= 0) InputError();
if (ArrayCoherence(size1, size2))
{
    int minArray = -20;
    int maxArray = 20;
    int[,] array1 = RandomTwoDimensionalArray(size1[0], size1[1], minArray, maxArray);
    int[,] array2 = RandomTwoDimensionalArray(size2[0], size2[1], minArray, maxArray);
    int[,] product = ProductOfArray(array1, array2);
    WriteProductOfArray(array1, array2, product);
}
else Console.WriteLine("Размеры массивов не согласованы - перемножение в таком порядке невозможно");