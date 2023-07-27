using System;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        if ((n / 100) * (n / 10 % 10) * (n % 10) >= 100)
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
}