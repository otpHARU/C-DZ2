// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Первое решение

// Console.WriteLine("Введите число, обозначающее день недели: ");
// int dayNumber = Convert.ToInt32(Console.ReadLine());
// if (dayNumber >= 6 && dayNumber <= 7)
// {
//     Console.WriteLine("Данный день является выходным");
// }
// else if (dayNumber < 6 && dayNumber > 0)
// {
//     Console.WriteLine("Данный день является рабочим");
// }
// else
// {
//    Console.WriteLine("Число вне пределов 7 дней, повторите попытку!"); 
// }

// Второе решение

// Console.WriteLine("Введите число, обозначающее день недели: ");
// int dayNumber = Convert.ToInt32(Console.ReadLine());
// while (dayNumber < 1 || dayNumber > 7)
// {
//     Console.WriteLine("Число вне пределов 7 дней, повторите попытку!");
//     Console.WriteLine("Введите число, обозначающее день недели: ");
//     dayNumber = Convert.ToInt32(Console.ReadLine());
// }
// if (dayNumber >= 6 && dayNumber <= 7)
// {
//     Console.WriteLine("Данный день является выходным");
// }
// else
// {
//     Console.WriteLine("Данный день является рабочим");
// }