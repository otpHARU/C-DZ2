// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Первое решение:

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number > 99)
// {
//     Console.WriteLine("Третья цифра в числе: " + number.ToString()[2]);
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет");
// }

// Второе решение:

// P.S. Зачем я это придумал? Ужас!

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int Number3;
// if (number > 99 && number < 999)
// {
//     Number3 = number % 10;
//     Console.WriteLine("Третья цифра числа: " + Number3);
// }
// if (number > 999 && number < 9999)
// {
//     Number3 = (number / 10) % 10;
//     Console.WriteLine("Третья цифра числа: " + Number3);
// }
// if (number > 9999 && number < 99999)
// {
//     Number3 = (number / 100) % 10;
//     Console.WriteLine("Третья цифра числа: " + Number3);
// }
// if (number <= 99)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
