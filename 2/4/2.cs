using System;
class Program
{
    static void Main()
    { 
        double x = Convert.ToDouble(Console.ReadLine());
        var y = Math.Pow((1 - x * x + 2.5f * x * x * x + Math.Pow(x, 4)), 2);

        Console.WriteLine(y);
    }
}