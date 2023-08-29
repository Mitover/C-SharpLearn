using System;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int n1 = n;
        int count = 0;
        while (n != 0)
        {
            n /= 10;
            count++;
        }
        Console.WriteLine(n1 + " contains " + count + " digits");
    }
}