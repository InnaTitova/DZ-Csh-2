// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день 
// выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.Write("Enter number: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 6 || a == 7)
{
    System.Console.WriteLine("Этот день является выходным днем");
}
if (a >= 1 && a <= 5)
{
    System.Console.WriteLine("Этот день рабочий");
}
if (a > 7 || a <= 0)
{
    System.Console.WriteLine("Такого дня недели нет");
}