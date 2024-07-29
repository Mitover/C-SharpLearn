using System;
class Program
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(' ');
        int a = int.Parse(numbers[0]);
        int b = int.Parse(numbers[1]);
        int n = int.Parse(numbers[2]);

        Console.WriteLine((a * n + b * n / 100) + "rub. " + b * n % 100 + "kop.");
    }
}
