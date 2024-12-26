static int[] MonkeyCount(int n)
{
    int[] result = new int[n];
    for (int i = 0; i < n; i++)
    {
        result[i] = i + 1;
    }
    return result;
}

// Also this!
//static int[] MonkeyCount(int n) => Enumerable.Range(1, n).ToArray();

int[] ints = MonkeyCount(5);
foreach (int i in ints)
{
    Console.WriteLine(i);
}