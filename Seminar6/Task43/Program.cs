// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void InputError()
{
    Console.WriteLine("Ошибка ввода, попробуйте еще раз");
    Environment.Exit(0);
}

string ОutputLineGeneration(double[,] array)
{
    return $"Прямые:     (1) y = {array[0,0]} * x + {array[0,1]}     (2) y = {array[1,0]} * x + {array[1,1]}     ->     ";
}

Console.Write("Коэффициенты k1 b1 для первой прямой (y = k1 * x + b1) через пробел: ");
string[] input1 = Console.ReadLine()!.Split();
if (input1.Length !=2) InputError();
Console.Write("Коэффициенты k2 b2 для второй прямой (y = k2 * x + b2) через пробел: ");
string[] input2 = Console.ReadLine()!.Split();
if (input2.Length != 2) InputError();
double[,] straight = new double[2,2];
for (int i=0; i < 2; i++)
{
    if (input1[i].IndexOf('.') != -1) {input1[i] = input1[i].Replace('.', ',');}
    if (input2[i].IndexOf('.') != -1) {input2[i] = input2[i].Replace('.', ',');}
    if (double.TryParse(input1[i], out var n1) && double.TryParse(input2[i], out var n2))
    {
        straight[0,i] = n1;
        straight[1,i] = n2;
    }
    else InputError();
}
if (straight[0,0] - straight[1,0] == 0) Console.WriteLine(ОutputLineGeneration(straight) + "не пересекаются (параллельны)");
else
{
    double intersectionPointX = (straight[1,1] - straight[0,1]) / (straight[0,0] - straight[1,0]);
    double intersectionPointY = ((straight[0,0] * straight[1,1] - straight[1,0] * straight[0,1])) / (straight[0,0] - straight[1,0]);
    Console.WriteLine(ОutputLineGeneration(straight) + $"пересекаются в точке ( x = {intersectionPointX} ; y = {intersectionPointY})");
}
