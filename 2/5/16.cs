using System;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(n / 100 % 10 * 1000 + n / 1000 * 100 + n / 10 % 10 + n % 10 * 10);
    }
}