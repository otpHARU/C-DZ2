// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Первое решение

// Console.WriteLine("Введите трёхзначное число: ");
// string number = Console.ReadLine();
// Console.WriteLine("Вторая цифра числа: " + number[1]);

// Второе решение

// Console.WriteLine("Введите трёхзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number >= 100 && number <= 999)
// {
// // int Number1 = number / 100; // Если нужно первое число
// int Number2 = (number / 10) % 10;
// // int Number3 = number % 10; // Если нужно второе число
// Console.WriteLine("Вторая цифра числа: " + Number2);
// }
// else
// {
//     Console.WriteLine("Введено некорректное число, повторите попытку");
// }

// Третье решение (немного поизвращался, но работает исправно)

// Было бы круто, если бы объяснил ошибки именно в этом примере (если они есть), так как учусь с 0 и придумывал этот вариант в голове долговато

// Console.WriteLine("Введите трёхзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// while (number < 100 || number > 999)
// {
//     Console.WriteLine("Введено некорректное число, повторите попытку!");
//     Console.WriteLine("Введите трёхзначное число: ");
//     number = Convert.ToInt32(Console.ReadLine());
// }
// // int Number1 = number / 100; // Если нужно первое число
// int Number2 = (number / 10) % 10;
// // int Number3 = number % 10; // Если нужно второе число
// Console.WriteLine("Вторая цифра числа: " + Number2);