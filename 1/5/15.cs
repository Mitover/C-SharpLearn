using System;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Math.Pow(n / 10000, 2) + Math.Pow(n / 1000 % 10, 2) + Math.Pow(n / 100 % 10, 2) + Math.Pow(n / 10 % 10, 2) + Math.Pow(n % 10, 2));
    }
}