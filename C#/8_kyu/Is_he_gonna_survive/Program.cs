static bool Hero(int bullets, int dragons) => bullets >= dragons * 2;

Console.WriteLine(Hero(10, 5)); // True
Console.WriteLine(Hero(7, 4)); // False