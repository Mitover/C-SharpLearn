using System;
class Program
{
    static void Main()
    {
        int m = Convert.ToInt32(Console.ReadLine());
        m = m * 45 + (m / 2) * 5 + ((m + 1) / 2 - 1) * 15;
        Console.WriteLine((m / 60 + 9) + " " + (m % 60));
    }
}

