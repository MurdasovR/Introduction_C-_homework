// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

bool FindElement(int[,] array, int desired)
{
    bool result = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == desired) result = true;
        }
    }
    return result;
}

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


int[,] array = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
Console.Clear();
int number = InputIntValue("Введите число для поиска");
Console.WriteLine("В массиве:");
WriteTwoDimensionalArray(array);
Console.Write("Число {0} -> ", number);
if (FindElement(array, number)) Console.WriteLine("есть");
else Console.WriteLine("отсутствует");