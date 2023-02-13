// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.Write("Enter number: ");
int a = Convert.ToInt32(Console.ReadLine());
string aText = Convert.ToString(a);
if (aText.Length > 2)
{
    System.Console.WriteLine($"Третья цифра числа: {aText[2]}");
}
else
{
    System.Console.WriteLine("Третья чифра числа отсутствует");
}