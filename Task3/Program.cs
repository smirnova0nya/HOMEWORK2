// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки для расчета.

// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(System.Console.ReadLine());
string NumberText = Convert.ToString(number);

if(NumberText.Length > 2)
{
System.Console.WriteLine($"{NumberText[2]}");
}
else
{
    System.Console.WriteLine("Третьей цифры нет");
}
