using System;
class Program
{
    static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        for (int i = a; i<=b; i++)
        {
            if (i/1000 == i%10 && i/100%10 == i/10%10)
                Console.WriteLine(i);
        }
    }
}