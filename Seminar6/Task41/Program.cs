// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int CountPositiveNumber(int[] array)
{
    int result = 0;
    for (int i =0; i < array.Length; i++)
    {
        if (array[i]>0) result++;
    }
    return result;
}

Console.Write("Введите целые числа через запятую: ");
string[] input = Console.ReadLine()!.Split(',');
int[] inputNumber = new int[input.Length];
for (int i=0; i < input.Length; i++)
{
    if (int.TryParse(input[i], out var n)) inputNumber[i] = n;
    else {Console.WriteLine("Ошибка ввода, попробуйте еще раз"); Environment.Exit(0);}
}
Console.WriteLine("В массиве [{0}] чисел больше нуля -> {1}", String.Join(" ; ", inputNumber), CountPositiveNumber(inputNumber));