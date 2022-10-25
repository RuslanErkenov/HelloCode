// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Write("Введите числа(через пробел): ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;


void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write(" ]");

}


int CountElements(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
      if (array[i] > 0)
      {
          count++;
      }
  }
  return count;
}

PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Кол-во элементов > 0: " + (CountElements(array)));