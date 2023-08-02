using System;
class Program
{
    static void Main()
    {
        int A = Convert.ToInt32(Console.ReadLine());
        int B = Convert.ToInt32(Console.ReadLine());
        while (A != B)
        {
            if (A % 2 == 0)
            {
                if (A / 2 < B)
                {
                    A -= 1;
                    Console.WriteLine("-1");
                }
                else
                {
                    A /= 2;
                    Console.WriteLine(":2");
                }
            }
            else
            {
                A -= 1;
                Console.WriteLine("-1");
            }
        }
    }
}