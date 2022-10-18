// 4 группы методов
// 1 группа

/* void Method1()
{
    Console.WriteLine("Auther...");
}
Method1(); */





//2 группа

/* void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Text of messange"); */


/* void Method21(string msg, int count)
{
    int i = 0;
    while (i < count){
        Console.WriteLine(msg);
        i++;
    }    
}
Method21("Text of messange", 4);  */




//3 группа

/*  int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year); */




// 4 группа

string Method4(int count, string c);
{
    int i = 0;
    string result = String.Empty;

      while (i < count)
      {
        result = result + text;
        i++;
      }
      return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);