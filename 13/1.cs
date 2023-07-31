using System;
class Program
{
    static void Main()
    {
        int mxNumber = -10000;
        int N = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > mxNumber)
            {
                mxNumber = num;
            }
        }
        Console.WriteLine(mxNumber);
    }
}