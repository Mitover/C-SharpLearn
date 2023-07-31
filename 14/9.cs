using System;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int k = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        while (n != 0)
        {
            if (n % 10 == k)
            {
                count += 1;
            }
            n /= 10;

        }
        Console.WriteLine(count);
    }
}