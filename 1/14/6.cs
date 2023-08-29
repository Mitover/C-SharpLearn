using System;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        while (n != 0)
        {
            n /= 10; // краткая запись n = n / 10   
            count++;
        }
        Console.WriteLine(n + " contains " + count + " digits");
    }
}