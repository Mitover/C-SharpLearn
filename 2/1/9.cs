using System;
class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        string Push = "";

        foreach (char c in s)
        {
            if (c == 'a') { Push += 'b'; }
            else if (c == 'b') { Push += 'a'; }
            else if (c == 'B') { Push += 'A'; }
            else if (c == 'A') { Push += 'B'; }
            else { Push += c; }
        }
        Console.WriteLine(Push);

    }
}