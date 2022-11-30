// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] GetRandomArray(int amount, int minValue, int maxValue)
{
    int[] array = new int[amount];
    for (int i = 0; i < amount; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void InputError()
{
    Console.WriteLine("Ошибка ввода, попробуйте еще раз");
}

Console.Write("Введите количество элементов массива: ");
if (!(int.TryParse(Console.ReadLine(), out int N)) || N <= 0) 
{
    InputError(); 
    Environment.Exit(0); 
}
Console.Write("Введите через пробел min и max значения массива: ");
string[] input = Console.ReadLine().Split(' ');
if (int.TryParse(input[0], out var minA) && int.TryParse(input[1], out var maxA))
{
    Console.WriteLine("[{0}]", String.Join(" ; ", GetRandomArray(N, minA, maxA)));
}
else
{
    InputError();
}
