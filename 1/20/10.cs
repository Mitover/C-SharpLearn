void printDiv(int number)
{
    for (int i = 1; i <= number; i++)
    {
        if (number % i == 0)
            Console.WriteLine(i + " ");
    }
}
int n = Convert.ToInt32(Console.ReadLine());
printDiv(n);