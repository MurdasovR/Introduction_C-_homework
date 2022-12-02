// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void WriteTwoDimensionalArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0, 4}", array[i, j]);
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

double[] AverageColumns(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        result[j] = (double)sum / array.GetLength(0);
    }
    return result;
}

string WriteDoubleArray(double[] array, int decimalPoint)
{
    string result = "[";
    for (int i = 0; i < array.Length - 1; i++) result += array[i].ToString(String.Format("F{0}", decimalPoint)) + " ; ";
    return result += array[array.Length - 1].ToString(String.Format("F{0}", decimalPoint)) + "]";
}


Console.Clear();
int rowsArray = new Random().Next(2, 11);
int columnsArray = new Random().Next(2, 11);
int minArray = -10;
int maxArray = 10;
int[,] array = RandomTwoDimensionalArray(rowsArray, columnsArray, minArray, maxArray);
Console.WriteLine("В массиве:");
WriteTwoDimensionalArray(array);
int precision = 2;
Console.WriteLine("Средние значения по столбцам: {0}", WriteDoubleArray(AverageColumns(array), precision));