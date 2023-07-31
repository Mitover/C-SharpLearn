using System;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int nNew = 0;
        int a = n;

        while (n != 0)
        {
            nNew = n % 10 + nNew * 10;
            n /= 10;
        }
        Console.WriteLine(nNew);
        Console.WriteLine(a - nNew);
    }
}