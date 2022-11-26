// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет 
// 12821 -> да
// 23432 -> да
Console.Write("Введите целое число: ");
bool Flag = true;
string Input = Console.ReadLine();
if (!(int.TryParse(Input, out int Number))) {Console.WriteLine("Ошибка ввода, попробуйте еще раз");}
else if (Number < 0) {Console.WriteLine("Число {0} - не палиндром", Number);}
else {
    for (int i=0; i < Input.Length / 2; i++) {
        if (Input[i] != Input[Input.Length-1-i]) {Flag = false; break;} } 
    if (Flag) {Console.WriteLine("Число {0} - палиндром", Number);}
    else {Console.WriteLine("Число {0} - не палиндром", Number);}
}