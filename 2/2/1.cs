using System;
class Program
{
    static void Main()
    {
        string str1 = Console.ReadLine();
        str1 = str1.Replace("@", "");
        Console.WriteLine(str1);
    }
}