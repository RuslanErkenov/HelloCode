﻿// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("enter m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("enter n: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];

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
              Console.Write($"{array[i,j]}   ");
        }
      Console.WriteLine();
    } 
    
} 



int SortSting(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {  
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < numbers.GetLength(1) - 1; z++)
            {        
                if (numbers[i, z] < numbers[i, z + 1]) //для изменения сортировки поменять знак < на противоположный
                    {
                    int temp = 0;
                    temp = numbers[i, z];
                    numbers[i, z] = numbers[i, z + 1];
                    numbers[i, z + 1] = temp;
                    }          
            }
        } 
    }
}

GetArray (array);
Console.WriteLine();
Console.WriteLine("Массив до изменения");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями");
SortSting(array);