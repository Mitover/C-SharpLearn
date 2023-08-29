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
            count += (n % 10);
            n /= 10;

        }
        Console.WriteLine("The sum of the digits of number " + n1 + " is " + count);
    }
}