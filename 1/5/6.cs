using System;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(n / 60 % 24 + " " + n % 60);
    }
}