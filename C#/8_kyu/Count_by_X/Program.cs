static int[] CountBy(int x, int n)
{
    int[] z = new int[n];
    for (int i = 1; i <= n; i++)
    {
        z[i - 1] = x * i;
    }
    return z;
}

int[] result = CountBy(1, 5);
foreach (int i in result)
{
    Console.WriteLine(i);   // 1, 2, 3, 4, 5
}
int[] result2 = CountBy(2, 5);
foreach (int i in result2)
{
    Console.WriteLine(i);   // 2, 4, 6, 8, 10
}