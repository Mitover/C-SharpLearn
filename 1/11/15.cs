using System;
class Program
{
    static void Main()
    {
        int N = Convert.ToInt32(Console.ReadLine());
        for (int i = (int)Math.Pow(10, N); i >= (int)Math.Pow(10, N - 1); i--)
        {
            if (i % 2 == 1)
            {
                Console.Write(i + " ");
            }
        }
    }
}