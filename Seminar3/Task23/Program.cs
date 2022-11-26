// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Write("Введите целое число N > 0: ");
if (!(int.TryParse(Console.ReadLine(), out int N)) || N <=0 ) {Console.WriteLine("Ошибка ввода, попробуйте еще раз"); Environment.Exit(0);}
//if (N == 1) {Console.WriteLine("От 1 до {0} четных чисел нет", N);}
//else {
else {
    Console.Write("Кубы чисел от 1 до {0}: ", N);
    for (int i = 1; i < N; i += 1) {Console.Write("{0}, ", Math.Pow(i, 3));}
    Console.WriteLine("{0}.", N*N*N);
}