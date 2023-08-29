using System;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine((n / 100 + n % 100 / 10 + n % 10) + " " + n.ToString()[0] + n.ToString()[2] + n.ToString()[1]);
    }
}