using System;
class Program
{
    static void Main()
    {
        int s = 0;
        for (int i = 100; i <= 500; i++)
            s = s + i;
        Console.WriteLine(s);
    }
}