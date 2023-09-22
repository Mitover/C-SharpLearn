using System;
class Program
{
    static void Main()
    {
        string name = Console.ReadLine();
        Console.WriteLine("Hello, " + name + "!");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(name + " ");
        }
    }
}