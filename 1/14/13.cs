using System;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int i = 0;
        int iPow = 1;

        while (iPow < n)
        {
            iPow *= 2;
            i++;
        }
        Console.WriteLine(i);
    }
}