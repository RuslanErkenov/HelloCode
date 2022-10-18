// Цикл for и циклы в цикле
/* string Method4(int count, string c);
{
    
    string result = String.Empty;
    for( int i =0;i < count; i++)
    {
        result = result + text;
    }
      return result;
}
string res = Method4(10, "z");
Console.WriteLine(res); */



for (int i = 2; i <= 9; i++){
    for (int j = 2; j < 10; j++){
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}