using System;
public class Kata
{
    public static string Bmi (double weight, double height)
    {
        var bmi = weight / (height * height);

        if (bmi <= 18.5) return "Underweight";

        if (bmi <= 25) return "Normal";

        if (bmi <= 30) return "Overweight";

        return "Obese";
    }
}