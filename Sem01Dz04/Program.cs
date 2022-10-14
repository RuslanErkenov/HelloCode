// На входе число, а на выходе все четные от 1 до числа на входе
//Console.Write("Enter number: ");
//int num = int.Parse(Console.ReadLine());
Console.Write("Write number 1: ");
int n = int.Parse(Console.ReadLine());
for (int number = 1; number < 21; number++)
{
    if (number % 3 == 0)
        {
            sum = sum + number;
        }
    }
    Console.WriteLine($"The sum is {sum}");
