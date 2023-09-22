using System;
class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        int Sum = 0;

        for (int i = 0; i < s.Length; i++)
        {
            Sum += Convert.ToInt32(s[i]);
        }
        Console.WriteLine(Sum);
    }
}