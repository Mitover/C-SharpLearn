using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double a = 0.999;

        CultureInfo ci = new CultureInfo("");
        a = a * Math.Pow(10, 2);
        a = Math.Truncate(a);
        a = a / Math.Pow(10, 2);
        Console.WriteLine(a.ToString(ci));

    }
}