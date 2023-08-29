using System;
class Program
{
    static void Main()
    {
        int s = Convert.ToInt32(Console.ReadLine());

        string tenMinutes = (s % 3600 / 60 / 10).ToString();
        string unitsMinutes = (s % 3600 / 60 % 10).ToString();

        string tenSec = (s % 3600 % 60 / 10).ToString();
        string unitSec = (s % 3600 % 60 % 10).ToString();
        Console.WriteLine((s % 86400 / 3600) + ":" + tenMinutes + unitsMinutes + ":" + tenSec + unitSec);
    }
}