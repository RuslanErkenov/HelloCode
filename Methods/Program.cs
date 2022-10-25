// See https://aka.ms/new-console-template for more information


int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write($"{array[i,j]} ");
        }
       Console.WriteLine();
    } 
    
}



string ArrayToString(int[,] array)
{
	string result = string.Empty;

	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			result += $"{array[i, j]} ";
		}

		result += Environment.NewLine;
	}

	return result;
}


/* 

int[] CreateArray(int size)
{
	int[] array = new int[size];

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = i;
	}

	return array;
}

int[] CopyArray(int[] originArray)
{
	int[] newArray = new int[originArray.Length];

	for (int i = 0; i < newArray.Length; i++)
	{
		newArray[i] = originArray[i];
	}

	return newArray;
}

string ArrayToString(int[] array)
{
	string result = string.Empty;

	for (int i = 0; i < array.Length; i++)
	{
		result += array[i] + " ";
	}

	return result;
}
int[] array = CreateArray(10);
Console.WriteLine(ArrayToString(array));
Console.WriteLine(ArrayToString(CopyArray(array)));

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



