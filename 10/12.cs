using System;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());
        int k = Convert.ToInt32(Console.ReadLine());

        if (k < n * m && (k % n == 0 || k % m == 0))
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
}