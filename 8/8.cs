using System;
class Program
{
    static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());

        if ((a % 10 + a / 10) > 10)
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");

        if ((a % 10 + a / 10) > n)
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
}