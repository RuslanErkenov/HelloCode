// программа по заданному номеру четверти показывает диапозон возможных координат двух точек
/*Console.Write("Enter X: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Enter Y: ");
int y = int.Parse(Console.ReadLine());

int result = 0;

int[,] array = new int[4, 2];

array[0, 0] = 1;
array[0, 1] = 1;

array[1, 0] = -1;
array[1, 1] = 1;

array[2, 0] = -1;
array[2, 1] = -1;

array[3, 0] = 1;
array[3, 1] = -1;

for (int i = 0; i < array.GetLength(0); i++)
{
	if ((x > 0 && array[i, 0] > 0) && (y > 0 && array[i, 1] > 0))
	{
		result = i;
	}
	else if ((x < 0 && array[i, 0] < 0) && (y > 0 && array[i, 1] > 0))
	{
		result = i;
	}
	else if ((x < 0 && array[i, 0] < 0) && (y < 0 && array[i, 1] < 0))
	{
		result = i;
	}
	else if ((x > 0 && array[i, 0] > 0) && (y < 0 && array[i, 1] < 0))
	{
		result = i;
	}
}

Console.WriteLine($"Result is {result + 1}");*/

Console.Write("Enter X: ");
int x = int.Parse(Console.ReadLine());

int[,] array = new int[4,5];

array[0, 1] = 1;
array[0, 2] = int.MaxValue;
array[0, 3] = 1;
array[0, 4] = int.MaxValue;

array[1, 1] = -1;
array[1, 2] = int.MinValue;
array[1, 3] = 1;
array[1, 4] = int.MaxValue;

array[2, 1] = -1;
array[2, 2] = int.MinValue;
array[2, 3] = -1;
array[2, 4] = int.MinValue;

array[3, 1] = 1;
array[3, 2] = int.MaxValue;
array[3, 1] = -1;
array[3, 2] = int.MinValue;

for (int i = 1; i <= array.GetLength(0); i++)
{
    array[i - 1, 0] = i;

Console.Write($" {array [x - 1 , i - 1]}");
}


