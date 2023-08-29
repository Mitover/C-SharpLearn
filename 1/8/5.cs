using System;
class Program
{
    static void Main()
    {
        string[] nums = Console.ReadLine().Split(' ');
        int a = int.Parse(nums[0]);
        int b = int.Parse(nums[1]);

        if (a > b)
            Console.WriteLine(a * 3 + " " + b * 2);
        else
            Console.WriteLine(a * 2 + " " + b * 3);
    }
}