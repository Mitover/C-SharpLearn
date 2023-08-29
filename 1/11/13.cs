using System;
class Program
{
    static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        for (int i = a + Math.Abs(a % 2 - 1); i <= b; i += 2)
        {
            Console.Write(i + " ");
        }
    }
}