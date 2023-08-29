using System;
class Program
{

    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("water - " + n + " kg");
        Console.WriteLine("cherry - " + n * 3 + " kg");
        Console.WriteLine("sugar - " + n * 2 + " kg");
        Console.WriteLine("jam - " + (n + n * 3 + n * 2) + " kg");
    }
}