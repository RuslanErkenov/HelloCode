// Сколько цифр в числе

/*string input = Console.ReadLine();
int count = int.Parse(input);

Console.WriteLine(GetLength(input));

int GetLength(string input)
{

	return input.Length;
}  */

// факториал от 1 до N

/* void factorial(int fact)
{
    int h1 = fact;
    long h2 = 1;
    if (fact == 0)
        Console.WriteLine(1);
    else
   {
        for (int i = 1; i <= h1; i++)
        {
            h2 *= i;
        }
    }
    Console.WriteLine(h2);
}
factorial(2);  */

// факториал рекурсией
/*
int number = int.Parse(Console.ReadLine());
Console.WriteLine(GetFactorial(number));


int GetFactorial(int number)
{
	if (number <= 1)
		return 1;

	return number * GetFactorial(number - 1);
}
*/


//Заполнить массив рандомными цифрами либо 0 либо 1

Massiv();
void Massiv()
{
    int[] N = new int[8];
        Console.Write("Массив [");
    for (int i = 0; i < N.Length; i++)
    {
        N[i] = new Random().Next(0, 2);
        Console.Write($"{N[i]}  ");
    }
    Console.Write("]");
}


/*
int[] a = new int[8];
FillBinarryArray(a);
Console.WriteLine(BinarryArrayToString(a));

void FillBinarryArray (int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(0, 2);

    }
}


string BinarryArrayToString(int[] a)
{
    string result = " ";
    for (int i = 0; i < a.Length; i++)
    {
        result += a[i];

    }


    return result;
}
*/