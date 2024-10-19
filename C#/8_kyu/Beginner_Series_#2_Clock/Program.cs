int Past(int h, int m, int s)
{
    return h * 60 * 60 * 1000 + m * 60 * 1000 + s * 1000;
}

Console.WriteLine(Past(0, 1, 1)); // 61000
Console.WriteLine(Past(1, 1, 1)); // 3661000