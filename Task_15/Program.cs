// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


System.Console.Write("Введите цифру соответсвующую дню недели: ");
int day_number = Convert.ToInt32(Console.ReadLine());

if (day_number > 0 && day_number < 6)
{
    System.Console.WriteLine("No");
}
else if (day_number > 7)
{
    System.Console.WriteLine("Такого дня недели нет");
}
else
{
    System.Console.WriteLine("Yes");
}