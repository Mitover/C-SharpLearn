using System;
class Program
{

    static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int d = Convert.ToInt32(Console.ReadLine());
        float avr = ((5 * a) + (b * 4) + (c * 3) + (d * 2)) / (a + b + c + d);
        int countStudent = 0;
        if (5 > avr)
            countStudent += a;
        if (4 > avr)
            countStudent += b;
        if (3 > avr)
            countStudent += c;
        if (2 > avr)
            countStudent += d;
        Console.WriteLine(countStudent);
    }
}