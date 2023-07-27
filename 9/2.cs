using System;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        if ((n >= 20) && (n <= 40))
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
}