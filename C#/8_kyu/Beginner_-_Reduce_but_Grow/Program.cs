int Grow(int[] x)
{
    int result = 1;
    for (int i = 0; i < x.Length; i++)
    {
        result *= x[i];
    }
    return result;
}

Console.WriteLine(Grow([1, 2, 3, 4])); // 24
