// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Massiv();
void Massiv()
{
    int[] N = new int[8];
        Console.Write("Массив [");
    for (int i = 0; i < N.Length; i++)
    {
        N[i] = new Random().Next(0,99);
        Console.Write($"{N[i]} ");
    }
    Console.Write("]");
}