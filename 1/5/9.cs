using System;
class Program
{
    static void Main()
    {
        int s = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("It is " + s / 3600 + " hours " + s % 3600 / 60 + " minutes.");
    }
}
