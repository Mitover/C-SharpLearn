using System;
class Program
{
    static void Main()
    {
        int mnNumber = 10000;
        int N = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            int num = Convert.ToInt32(Console.ReadLine());
    
            if (num < mnNumber && num%2==0)
                mnNumber = num;
        }
        Console.WriteLine(mnNumber);
    }
}