using System;
class Program
{
    static void Main(string[] args)
    {
        int a, b, c, d;
        string[] numbers = Console.ReadLine().Split(' ');
        a = Convert.ToInt32(numbers[0]);
        b = Convert.ToInt32(numbers[1]);
        c = Convert.ToInt32(numbers[2]);
        d = Convert.ToInt32(numbers[3]);
     
        Console.WriteLine(a + " " + b + " " + c + " " + d);
    }
}