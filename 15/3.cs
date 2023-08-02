using System;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int i = 0;
        while (n != 0)
        {
            if (n % 10 == 3 && n > 9 && n < 100)
                i++;

            n = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(i);
    }
}