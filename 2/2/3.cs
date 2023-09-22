using System;
class Program
{
    static void Main()
    {
        string word = Console.ReadLine();
        int index1 = word.IndexOf('h');
        int index2 = word.LastIndexOf('h');
        Console.WriteLine(word.Remove(index1, index2 - index1 + 1));
    }
}