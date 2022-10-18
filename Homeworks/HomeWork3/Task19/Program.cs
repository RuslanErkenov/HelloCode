// Поллиндром ли пятизначное число?
/*Console.WriteLine("Enter five - digit number: ");
int a = int.Parse(Console.ReadLine());
string str = a.ToString();
int[] array = new int[4];

for( int i=0; i <= 4; i++)
{
     array[i] = int.Parse(str[i].ToString());
}

if (array[0] == array[4]){
    if (array[1] == array[3]){
        Console.WriteLine("True!)");
        }
}
else{
    Console.WriteLine("Folse;(");
}
*/
Console.WriteLine("Enter five - digit number: ");
int a = int.Parse(Console.ReadLine());
string str = a.ToString();
int[] b = new int[4];
for( int i=0; i < 5; i++)
{
     b[i] = int.Parse(str[i].ToString());
     Console.Write(b[i]);
}
 