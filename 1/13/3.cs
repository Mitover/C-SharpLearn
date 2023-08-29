using System;
class Program
{
    static void Main()
    {
        int mnPos = 0, mxPos = 0;
        int mxNumber = -10000, mnNumber = 10000;
        int N = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > mxNumber)
            {
                mxPos = i;
                mxNumber = num;
            }
            if (num < mnNumber)
            {
                mnPos = i;
                mnNumber = num;
            }
        }
        Console.WriteLine(mnPos + " " + mxPos);
    }
}