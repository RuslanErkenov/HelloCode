// See https://aka.ms/new-console-template for more information
int num = new Random().Next(100, 999);

int result = ((number / 100) * 10) + number %10;

Console.WriteLine(num);
Console.WriteLine(result);

System.Comsole.WriteLine($"Was {number}, Now {result}"); // ("Was " + number + "..." + result)