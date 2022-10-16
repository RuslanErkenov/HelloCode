// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Enter number day of the week: ");
int a = int.Parse(Console.ReadLine());

switch (a)
{
    case 1: Console.WriteLine("Mondey, first weekday;(("); break;
    case 2: Console.WriteLine("Tuesday, weekday"); break;
    case 3: Console.WriteLine("Wednesday, weekday"); break;
    case 4: Console.WriteLine("Thursday, weekday"); break;
    case 5: Console.WriteLine("Friday, weekday"); break;
    case 6: Console.WriteLine("Saturday, WEEKEND!!!)"); break;
    case 7: Console.WriteLine("Sunday, WEEKEND!!!)"); break;
}
