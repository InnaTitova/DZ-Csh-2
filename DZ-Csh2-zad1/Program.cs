// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int a1 = a / 10;
int a2 = a1 % 10;

if (a >= 100 && a <= 999)
{
        System.Console.WriteLine($"Secound number: {a2}");
}
else
{
    System.Console.WriteLine("Введенное число не является трехзначным");
}
