// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Не использовать строки для расчета.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int Prompt(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(System.Console.ReadLine());
    return number;
}
bool ValidateNumber(int number)
{
    if(number < 100 || number > 1000)
    {
    System.Console.WriteLine("Это не трехзначное число");
    return false;
    } 
   return true;
}
   int number = Prompt("Введите трехзначное число: ");
   if(ValidateNumber(number))
   {
    int firstDigit = number / 10;
    int middleDigit = firstDigit % 10;
    Console.WriteLine($"вторая цифра числа {number} равна {middleDigit}");
   }