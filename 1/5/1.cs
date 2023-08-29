using System;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string[] numbers = Console.ReadLine().Split(' ');
            x = int.Parse(numbers[0]);
            y = int.Parse(numbers[1]);

            Console.WriteLine(x + "/" + y + "=" + x / y);
            Console.WriteLine(x + "%" + y + "=" + x % y);
        }
    }
}