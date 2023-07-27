using System;
class Program
{
    static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int max;
        if (a > b)
            max = a;
        else
            max = b;
        Console.WriteLine("Maximum is " + max);
    }
}