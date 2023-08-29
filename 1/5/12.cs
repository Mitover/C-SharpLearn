using System;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, n;
            string[] numbers = Console.ReadLine().Split(' ');
            k = int.Parse(numbers[0]);
            n = int.Parse(numbers[1]);

            Console.WriteLine(((n + k - 1) / k) + " " + ((n - 1) % k + 1));
        }
    }
}