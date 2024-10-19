static int[] ReverseSeq(int n)
{
    int[] result = new int[n];
    for (int i = 0; i < n; i++)
    {
        result[i] = n - i;
    }
    return result;
    
    // This is also a good solution, but as with most of these
    // challenges, using libraries like this abstracts away the
    // underlying logic and doesn't help you learn as much.

    // return Enumerable.Range(1, n).Reverse().ToArray();
}

int[] ints = ReverseSeq(5);
foreach (int i in ints)
{
    Console.WriteLine(i);
}