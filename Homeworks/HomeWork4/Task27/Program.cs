// Напишите программу, которая принимает на 
// вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Enter your Number: ");
int n = int.Parse(Console.ReadLine());
string str = n.ToString();
int[] b = new int[str.Length];
int result = 0;
for( int i=0; i< str.Length; i++)
{
     b[i] = int.Parse(str[i].ToString());
     result = result + b[i];
}
Console.WriteLine(result);