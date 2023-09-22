using System;
class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        bool low = false;
        bool high = false;
        bool numbers = false;
        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsDigit(s[i])) numbers = true;
            if (char.IsLower(s[i])) low = true;
            if (char.IsUpper(s[i])) high = true;
        }
        if (low && high && numbers && s.Length >= 8)
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
}