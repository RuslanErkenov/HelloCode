Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine());
int first = -num;
while (first < num + 1)
{
     Console.WriteLine(first);
     first++;
}