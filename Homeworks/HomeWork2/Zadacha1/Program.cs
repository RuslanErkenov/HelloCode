// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Enter three-digit number: ");
int n = int.Parse(Console.ReadLine());

int result = (n - ((n / 100)) * 100) / 10;

Console.WriteLine($"Was {n}, now {result}");