static string Bmi(double weight, double height)
{
    double bmi = weight / (height * height);
    return bmi > 30 ? "Obese" : bmi >= 25 ? "Overweight" : bmi >= 18.5 ? "Normal" : "Underweight";
}

Console.WriteLine(Bmi(50, 1.80)); // Underweight
Console.WriteLine(Bmi(80, 1.80)); // Normal
Console.WriteLine(Bmi(90, 1.80)); // Overweight
Console.WriteLine(Bmi(110, 1.80)); // Obese