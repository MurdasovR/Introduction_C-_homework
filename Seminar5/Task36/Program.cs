// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetRandomArray(int amount, int minValue, int maxValue)
{
    int[] array = new int[amount];
    for (int i = 0; i < amount; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int SumOddPositions(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        result += array[i];
    }
    return result;
}

void InputError()
{
    Console.WriteLine("Ошибка ввода, попробуйте еще раз");
    Environment.Exit(0);
}

Console.Write("Введите количество элементов массива: ");
if (!(int.TryParse(Console.ReadLine(), out int N) && N > 0)) InputError();
Console.Write("Введите через пробел min и max значения массива: ");
string[] input = Console.ReadLine().Split(' ');
if (input.Length != 2) InputError();
if (int.TryParse(input[0], out var minA) && int.TryParse(input[1], out var maxA) && maxA > minA) 
{ 
    int[] massiv = GetRandomArray(N, minA, maxA);
    Console.WriteLine("В массиве [{0}] сумма нечетных позиций => {1}", String.Join(" ; ", massiv), SumOddPositions(massiv));
}
else InputError();