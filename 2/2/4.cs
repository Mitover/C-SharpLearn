using System;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        string str = Console.ReadLine();
        Console.WriteLine(str.Replace("1", "one"));
    }
}