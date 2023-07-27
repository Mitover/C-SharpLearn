using System;
class Program
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(' ');
        int a = int.Parse(numbers[0]);
        int b = int.Parse(numbers[1]);
        int c = int.Parse(numbers[2]);

        if (a <= b && b <= c)
            Console.WriteLine("on growth!");
        else
            Console.WriteLine("dont on growth!");
    }
}