using System;
class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        string newS = "";
        foreach (char i in s)
        {
            if (Char.IsUpper(i) && newS.Length < 3)
            {
                newS += i + ".";
            }
        }
        Console.WriteLine(s.Substring(s.LastIndexOf(" ") + 1) + " " + newS);
    }
}