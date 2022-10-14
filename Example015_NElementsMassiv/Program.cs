// Массив arrey из N элементов, найти элемент find.
//Console.WriteLine("Hello, World!");
int[] array = { 4, 12, 31, 4, 15, 16, 38, 42, 51};

int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        //break;  если хочу остановиться на первом найденном элементе
    }
    index++;
}