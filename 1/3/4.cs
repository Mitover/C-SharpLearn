using System;
class Program
{
    static void Main(string[] args)
    {
        int a, b;
        string[] numbers = Console.ReadLine().Split(' ');
        a = Convert.ToInt32(numbers[0]);
        b = Convert.ToInt32(numbers[1]);

        Console.WriteLine(a * b);
    }
}