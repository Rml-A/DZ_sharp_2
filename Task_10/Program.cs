// Задача 10: Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1



System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int newNumber = number % 100;

System.Console.WriteLine(newNumber / 10);
