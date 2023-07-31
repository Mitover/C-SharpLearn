using System;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int i = 0;
        while (n != 0)
        {
            i += n;
            n = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(i);
    }
}