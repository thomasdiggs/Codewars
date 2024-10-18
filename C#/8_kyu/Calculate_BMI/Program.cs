static string Bmi(double weight, double height)
{
    double bmi = weight / (height * height);
    return bmi <= 18.5 ? "Underweight" :
        bmi <= 25.0 ? "Normal" :
        bmi <= 30.0 ? "Overweight" :
        bmi > 30 ? "Obese": "";
}

Console.WriteLine(Bmi(50, 1.80)); // Underweight
Console.WriteLine(Bmi(80, 1.80)); // Normal
Console.WriteLine(Bmi(90, 1.80)); // Overweight
Console.WriteLine(Bmi(110, 1.80)); // Obese