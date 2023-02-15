// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int num;
int secondNumber;

Console.Write("Enter a three digit number: ");
num = Convert.ToInt32(Console.ReadLine());
secondNumber = (num / 10) % 10;

Console.Write("\nSecond digit of the number is : " + secondNumber);