using System;
class Program
{
    static void Main()
    {
        double x = Convert.ToDouble(Console.ReadLine()) * 100;
        double p = Convert.ToDouble(Console.ReadLine());
        double y = Convert.ToDouble(Console.ReadLine()) * 100;
        int i = 0;

        while (x < y)
        {
            double b = x * (1 + (p / 100));
            x = Convert.ToInt32(b);
            i++;
        }
        Console.WriteLine(i);
    }
}