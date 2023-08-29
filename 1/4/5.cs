using System;
class Program
{
    static void Main()
    {
        double x = Convert.ToDouble(Console.ReadLine());
        double y = Convert.ToDouble(Console.ReadLine());
        double c = (x + y) / (x + 1) - (x * y - 12) / (34 + x);
        Console.WriteLine(c);
    }
}