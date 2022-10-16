// На входе число, а на выходе все четные от 1 до числа на входе

Console.Write("Write your number: ");
int n = int.Parse(Console.ReadLine());

if (n > 0){
    for (int i = 1; i <= n; i++){
        if (i % 2 == 0){
            Console.WriteLine(i);
        }
    }
} else if (n < 0){
    for (int i = 1; i >= n; i--){
        if (i % 2 == 0 && i != 0){
            Console.WriteLine(i);
        }
    }
}

