using System;
class Program
{
    static void Main()
    {
        int n1 = 1;
        int n2 = 0;
        int sum = 0;
        int count = 0;
        int chisla = Convert.ToInt32(Console.ReadLine());
        while (count < chisla)
        {
            sum = n1 + n2;
            n1 = n2;
            n2 = sum;
            count++;
        }
        Console.WriteLine(sum);
    }
}