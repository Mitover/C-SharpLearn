using System;
class Program
{
    static void Main()
    {
        int sum = 0;
        int nul = 0;
        while (nul != 2)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 0)
            {
                nul++;
            }
            else
            {
                sum += n;
                nul = 0;
            }
        }
        Console.WriteLine(sum);
    }

}