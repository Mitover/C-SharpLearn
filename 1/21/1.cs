int printDiv(int number)
{
    int count = 0;
    for (int i = 1; i <= number; i++)
    {
        if (number % i == 0)
            count++;
    }
    return count;
}


int answer = 0;
int maxDivider = 0;

for (int i = 0; i < 5; i++)
{
    int number2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(number2 + "имеет делителей : " + printDiv(number2));
    if (printDiv(number2) > maxDivider || printDiv(number2) == maxDivider && answer < number2)
    {
        answer = number2;
        maxDivider = printDiv(number2);
    }

}
Console.WriteLine(answer);