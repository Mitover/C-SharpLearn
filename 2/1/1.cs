for (int i = 1; i < array.Length; i++)
{
    if (array[i] > array[i - 1])
    {
        countMore++;
    }
}
Console.WriteLine(countMore);