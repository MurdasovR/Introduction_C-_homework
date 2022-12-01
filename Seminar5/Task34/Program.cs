// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetRandomArray(int amount, int minValue, int maxValue)
{
    int[] array = new int[amount];
    for (int i = 0; i < amount; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int CountEvenElements(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result++;
        }
    }
    return result;
}

void InputError()
{
    Console.WriteLine("Ошибка ввода, попробуйте еще раз");
}

Console.Write("Введите количество элементов массива: ");
if (int.TryParse(Console.ReadLine(), out int N) && N > 0)
{
    int[] massiv = GetRandomArray(N, 100, 999);
    Console.WriteLine("В массиве [{0}] => {1} четных", String.Join(" ; ", massiv), CountEvenElements(massiv));
}
else
{
    InputError();
}