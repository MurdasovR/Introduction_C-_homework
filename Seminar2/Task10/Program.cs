// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Write("Введите целое трёхзначное число: ");
string Input = Console.ReadLine();
if (!(int.TryParse(Input, out int Number)) || (Number < -999 || (Number > -100 && Number < 100) || Number > 999) ) 
{Console.WriteLine("Ошибка ввода, попробуйте еще раз"); Environment.Exit(0);}
else if (Number > 0) {Console.WriteLine("Вторая цифра справа в числе {0} -> {1} или {2}", Number, Input[1], (Number % 100) / 10);}
else {Console.WriteLine("Вторая цифра справа в числе {0} -> {1} или {2}", Number, Input[2], -(Number % 100) / 10);}