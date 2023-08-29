using System;
class Program
{
    static void Main()
    {
        int count = 0;
        int mxAv = 0;
        int N = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == mxAv)
            {
                count++;
            }
            if (mxAv < number)
            {
                mxAv = number;
                count = 1;
            }
        }
        Console.WriteLine(count);
    }
}