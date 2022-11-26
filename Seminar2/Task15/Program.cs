// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
string[] NameDayWeek = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
Console.Write("Введите порядковый номер дня недели: ");
if (!(int.TryParse(Console.ReadLine(), out int Number)) || Number <= 0 || Number > 7 ) {Console.WriteLine("Ошибка ввода, попробуйте еще раз"); Environment.Exit(0);}
else if (Number == 6 || Number == 7) {Console.WriteLine("{0} - выходной день", NameDayWeek[Number-1]);}
else {Console.WriteLine("{0} - рабочий день", NameDayWeek[Number-1]);}