int[] array = RandomArray(5, true);
Console.WriteLine("Все элементы массива " + string.Join(" ", array));
bool isYes = false;
for (int i = 0; i < array.Length - 1; i++)
{
    if (array[i] > 0 && array[i + 1] > 0 || array[i] < 0 && array[i + 1] < 0)
    {
        isYes = true;
    }
}
if (isYes)
    Console.WriteLine("YEs");
else
    Console.WriteLine("NO");