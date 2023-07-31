using System;
class Program
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(' ');
        int a = int.Parse(numbers[0]);
        int b = int.Parse(numbers[1]);
        int Suma = 1;

        for (int i = a; i <= b; i++)
        {
            if (Math.Abs(i * 6 % 10) == 2)
                Suma *= i;
        }
        if (Suma > 1)
            Console.WriteLine(Suma);
        else
            Console.WriteLine(0);
    }
}