// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.Write("Enter number: ");
int n = int.Parse(Console.ReadLine());
if (n > 99){
   Console.WriteLine(n>99 ? n.ToString()[2] : '-');
}
else if (n < -99){
   Console.WriteLine(n<-99 ? n.ToString()[3] : '-');
}   
else{
   Console.WriteLine("We have not three and more digit((");
}



/*int num = ReadInt("Enter number: ");
int count = num.ToString().Length;
Console.Write(MakeArray(num, count));

// ФУНКЦИИ------------------------------------------------------------------------------------------------------

// Функция принимает сообщение для отображения в консоли, и выводит результат введенных данных пользователем.
int ReadInt(string message)
{
   Console.Write(message);
   return Convert.ToInt32(Console.ReadLine());
}

// Функция принимает число введенное пользователем, количество символов, и выводит третью цифру числа. Если 3 цифры нет, сообщает и выводит 0.
int MakeArray(int a, int b)
{
int result = 0;
    if (b < 3)
    {
        Console.Write("Третьей цифры нет, держи: ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
return result;
} */
