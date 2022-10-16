// Принимаем на вход три числа и выдаем максимальное
Console.Write("Enter first number: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Enter third number: ");
int c = int.Parse(Console.ReadLine());

if (a > b && a > c)
    Console.WriteLine("Nubmer Max = " + a); 
else if (b > c)
    Console.WriteLine("Number Max = " + b); 
else
    Console.WriteLine("Number Max = " + c); 