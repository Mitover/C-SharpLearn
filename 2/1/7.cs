using System;
class Program
{
    static void Main()
    {
        string word = Console.ReadLine();
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(word[a] + "" + word[b]);

        // string word = Console.ReadLine();
        // int number1 = Convert.ToInt32(Console.ReadLine());
        // int number2 = Convert.ToInt32(Console.ReadLine());
        // for (int i = number1; i < number2; i++)
        // {
        //     Console.Write(word[i]);
        // }
    }
}
