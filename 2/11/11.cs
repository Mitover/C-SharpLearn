using System;
class Program
{
    static void Main()
    {
        int i = 1;
        int N = Convert.ToInt32(Console.ReadLine());
        for (i = 1; i <= 10; i++)
            Console.WriteLine(N + "*" + i + "=" + (N * i));
    }
}