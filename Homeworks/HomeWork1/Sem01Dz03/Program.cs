// Принимаем число и выводим, является ли оно четным
Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());
if (number % 2 == 0)
    Console.WriteLine("Number " + number + " is even, TRUE");
else
    Console.WriteLine("Number " + number + " is odd, FALSE");