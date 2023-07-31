using System;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int i = 1;
        while (i * i <= n)
        {
            Console.Write(i * i + " ");
            i++;
        }
    }
}