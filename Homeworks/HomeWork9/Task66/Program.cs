/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Введите начальное число m:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите начальное число n:");
int n = int.Parse(Console.ReadLine());


void SumOfNumbers (int m, int n, int sum)
{
    if (m > n) 
    {
        Console.WriteLine($"Сумма: {sum}"); 
        return;
    }

    sum = sum + (m++);
    SumOfNumbers(m, n, sum);
}

SumOfNumbers(m, n, 0);