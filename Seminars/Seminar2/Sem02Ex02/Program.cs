// See https://aka.ms/new-console-template for more information
int num = new Random().Next(100, 999);

int result = ((num / 100) * 10) + num %10;

Console.WriteLine(num);
Console.WriteLine(result);

System.Console.WriteLine($"Was {num}, Now {result}"); // ("Was " + number + "..." + result)