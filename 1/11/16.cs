using System;
class Program
{
    static void Main()
    {
        for (int i =10; i<=100; i++)
        {
            if ( ((i/10)*(i%10)*2) == i)
                Console.Write(i);
        }
    }
}

