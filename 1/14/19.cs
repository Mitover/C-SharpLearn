using System;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int mx = n;
        int count = 0;
        while (n != 0)
        {
            if (n > mx)
            {
                mx = n;
                count = 1;
            }
            else if (n == mx)
                count++;
            n = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(count);
    }
}