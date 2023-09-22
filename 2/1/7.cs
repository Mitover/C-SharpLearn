using System;
class Program
{
    static void Main()
    {
        string word = Console.ReadLine();
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(word[a] + "" + word[b]);
    }
}