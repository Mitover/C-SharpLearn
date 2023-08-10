using System;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int oldNumber = n;
        int count = 0;
        while (n != 0)
        {
            n = Convert.ToInt32(Console.ReadLine());
            if (n > oldNumber)
                count++;
            oldNumber = n;


        }
        Console.WriteLine(count);
    }
}