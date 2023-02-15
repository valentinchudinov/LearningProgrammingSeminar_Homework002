//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("\nPlease enter a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int thirdDigit = number % 100;

if (number >= 100 && number <= 999)
{
    int secondDigit = thirdDigit % 10;
    Console.WriteLine("The second digit is " + secondDigit);
}
else 
{
    Console.WriteLine("This number has no third digit.");
}
