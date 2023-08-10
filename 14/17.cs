using System;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int mxEv = -100;
        while (n != 0)
        {
            if (n % 2 == 0)
                if (mxEv < n)
                    mxEv = n;
            n = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(mxEv);
    }
}