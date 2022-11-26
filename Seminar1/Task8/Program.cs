// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Write("Введите целое число N>0: ");
if (!(int.TryParse(Console.ReadLine(), out int N)) | N <=0 ) {Console.WriteLine("Ошибка ввода, попробуйте еще раз"); Environment.Exit(0);}
if (N == 1) {Console.WriteLine("От 1 до {0} четных чисел нет", N);}
else {
    Console.Write("Четные числа от 1 до {0}: ", N);
    for (int i = 2; i < N-1; i += 2) {Console.Write("{0}, ", i);}
    if (N % 2 == 1) {Console.WriteLine("{0}.", N-1);}
    else {Console.WriteLine("{0}.", N);}
}