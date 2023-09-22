using System;
class Program
{
    static void Main()
    {
        string sistem = Console.ReadLine();
        string paswword = Console.ReadLine();
        if (sistem == paswword) { Console.WriteLine("Access"); }
        else { Console.WriteLine("Invalid password"); }
    }
}