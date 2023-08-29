using System;
class Program
{
    static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        if (a < b)
        {
            for (int i = a; i <= b; i++)
            {
                Console.Write(i + " ");
            }
        }
        else
        {
            for (int i = a; i >= b; i--)
            {
                Console.Write(i + " ");
            }
        }
    }
}