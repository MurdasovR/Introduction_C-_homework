// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int Divider (int Lenght) {
    int D = 1;
    for (int i=1; i<Lenght-1; i++) {D = D * 10;}
return D;}

Console.Write("Введите целое число: ");
string Input = Console.ReadLine();
if (!(int.TryParse(Input, out int Number))) {Console.WriteLine("Ошибка ввода, попробуйте еще раз"); Environment.Exit(0);}
else if (Number > -100 && Number < 100) {Console.WriteLine("Число {0} имеет менее трех знаков", Number);} 
else if (Number > 0) {Console.WriteLine("Третья цифра слева в числе {0} -> {1} или {2}", Number, Input[2], (Number % Divider(Input.Length) / (Divider(Input.Length)/10)));}
else {Console.WriteLine("Третья цифра слева в числе {0} -> {1} или {2}", Number, Input[3], -(Number % Divider(Input.Length-1) / (Divider(Input.Length-1)/10)));}