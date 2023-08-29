using System;
class Program
{
    static void Main()
    {
        double x = Convert.ToDouble(Console.ReadLine());
        double y = Convert.ToDouble(Console.ReadLine());
        int i = 1;
        while (x < y)
        {
            x = x * 1.1;
            i++;
        }
        Console.WriteLine(i);
    }
}