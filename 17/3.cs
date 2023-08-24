using System;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int max = 0;
        int second = 0;

        while (n != 0)
        {
            if (max < n)
            {
                second = max;
                max = n;
            }
            else if (n > second)
            {
                second = n;
            }
            n = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(second);
    }
}