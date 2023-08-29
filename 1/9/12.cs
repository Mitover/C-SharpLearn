using System;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int p60 = 0, p10 = 0, p1 = 0;
        if (n >= 60)
        {
            if (n % 60 / 10 * 125 + n % 60 % 10 * 15 > 440)
            {
                p60 += n / 60 + 1;
                n -= n / 60 * 60 - n % 60;
            }
            else
            {
                p60 += n / 60;
                n -= n / 60 * 60;
                if (n >= 10 && n % 10 <= 8)
                {
                    p10 += n / 10;
                    n -= n / 10 * 10;
                    p1 = n;
                }
                else if (n >= 10 && n % 10 > 8)
                    p10 += n / 10 + 1;
                else if (n % 10 > 8)
                    p10 = 1;
                else
                    p1 = n;
            }

        }
        else if (n / 10 * 125 + n % 10 * 15 > 440)
        {
            p60 = 1;
        }
        else
        {
            if (n >= 10 && n % 10 <= 8)
            {
                p10 += n / 10;
                n -= n / 10 * 10;
                p1 = n;
            }
            else if (n >= 10 && n % 10 > 8)
            {
                p10 += n / 10 + 1;
            }
            else if (n % 10 > 8)
            {
                p10 = 1;
            }
            else
            {
                p1 = n;
            }
        }
        Console.WriteLine(p1 + " " + p10 + " " + p60);

    }
}





