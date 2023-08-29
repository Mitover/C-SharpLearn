using System;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(((m - 1) / n) + 1);
    }
}