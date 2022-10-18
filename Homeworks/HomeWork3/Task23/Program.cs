// На вход число н, а на выходе кубы чисел от 1 до н
Console.Write("Your number: ");
int number = int.Parse(Console.ReadLine());

for (int i = 1 ; i <= number ; i++){
    Console.Write($"{Math.Pow(i , 3)}  ");
}
