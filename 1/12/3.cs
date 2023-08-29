using System;
class Program
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(' ');
        int a = int.Parse(numbers[0]);
        int b = int.Parse(numbers[1]);
        int Suma = 0;
        for (int i = a; i <= b; i++)
            Suma += i;
        Console.WriteLine(Suma);
    }
}