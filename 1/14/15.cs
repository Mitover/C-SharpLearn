using System;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int i = 0;
        while (n != 0)
        {
            if (n % 3 == 0)
                i++;
            n = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(i);
    }
}