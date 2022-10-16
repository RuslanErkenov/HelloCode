// See https://aka.ms/new-console-template for more information
Console.WriteLine("First number: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Second number: ");
int b = int.Parse(Console.ReadLine());
int result = a % b;
if (result == 0){
    Console.WriteLine("Успешно разделили a на b ");
}
else
{
    Console.WriteLine(result);
}


