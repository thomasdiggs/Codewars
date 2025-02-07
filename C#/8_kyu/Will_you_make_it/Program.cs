static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft) => distanceToPump <= mpg * fuelLeft;

Console.WriteLine(ZeroFuel(50, 25, 2)); // true
Console.WriteLine(ZeroFuel(100, 50, 1)); // false