//Задача на введение двух чисел и вывода большего из них
Console.Write("Enter first number: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int b = int.Parse(Console.ReadLine());

if (a < b)
{
    Console.WriteLine("max = " + b);
    Console.WriteLine("min = " + a);
}
else
{
    Console.WriteLine("max = " + a);
    Console.WriteLine("min = " + b);
}