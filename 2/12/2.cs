using System;
class Program
{
    static void Main()
    {
        int b = Convert.ToInt32(Console.ReadLine());
        int s = 0;
        for (int i = -10; i <= b; i++)
            s = s + i;
        Console.WriteLine(s);
    }
}