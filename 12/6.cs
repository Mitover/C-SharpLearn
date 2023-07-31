using System;
class Program
{
    static void Main()
    {
        int N = Convert.ToInt32(Console.ReadLine());
        int Suma = 0;

        for (int i = 1; i < N; i++)
        {
            Suma += i * (i + 1);
            if (i != N - 1)
                Console.Write(i + "*" + (i + 1) + "+");
            else
                Console.Write(i + "*" + (i + 1) + "=" + Suma);
        }
    }
}