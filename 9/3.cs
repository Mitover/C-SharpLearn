using System;
class Program
{
    static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        if (a == b && b == c)
            Console.WriteLine(3);
        else if (a == b && b != c || a == c && c != b || b == c && a != b)
            Console.WriteLine(2);
        else
            Console.WriteLine(0);
    }
}