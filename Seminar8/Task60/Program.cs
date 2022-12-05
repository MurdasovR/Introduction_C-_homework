// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[] InputIntTripleArray(string question)
{
    Console.Write(question + ": ");
    string[] input = Console.ReadLine()!.Split();
    if (input.Length != 3) InputError();
    int[] result = new int[3];
    for (int i = 0; i < 3; i++)
    {
        if (int.TryParse(input[i], out var number)) result[i] = number;
        else InputError();
    }
    return result;
}

void InputError()
{
    Console.WriteLine("Ошибка ввода, попробуйте еще раз");
    Environment.Exit(0);
}


bool ElementSearch(int element, int[,,] array, int iExtreme, int jExtreme, int kExtreme)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (i == iExtreme && j == jExtreme && k == kExtreme) return false; // otherwise zero cannot be an element of the matrix
                if (array[i, j, k] == element) return true;
            }
        }
    }
    return false;
}

int[,,] Random3DArray(int row, int column, int depth, int minValue, int maxValue)
{
    int[,,] result = new int[row, column, depth];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            int k = 0;
            while (k < depth)
            {
                int temp = new Random().Next(minValue, maxValue + 1);
                if (!ElementSearch(temp, result, i, j, k)) result[i, j, k++] = temp;
            }
        }
    }
    return result;
}

void Write3DArray(int[,,] array)
{
    Console.WriteLine("\nМассив случайных неповторяющихся элементов размером {0} х {1} х {2}:", array.GetLength(0), array.GetLength(1), array.GetLength(2));
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write("({0,2},{1,2},{2,2}) = {3,5}, {4,5}", i, j, k, array[i, j, k], "");
            }
            Console.WriteLine();
        }
    }
}


Console.Clear();
int[] size = InputIntTripleArray("Введите три размера трехмерной матрицы через пробел");
if (size[0] <= 0 || size[1] <= 0 || size[2] <= 0) InputError();
int minValue = 0;
int maxValue = size[0] * size[1] * size[2];
int[,,] array = Random3DArray(size[0], size[1], size[2], minValue, maxValue);
Write3DArray(array);