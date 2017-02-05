using System;

class Practice
{
    static void Main()
    {
        var fahrenheit = double.Parse(Console.ReadLine());
        var celsius = ConvertFromFahrenheitToCelsius(fahrenheit);
        Console.WriteLine(celsius);
    }

    private static double ConvertFromFahrenheitToCelsius(double fahrenheit)
    {
        var converted = (fahrenheit - 32) * 5 / 9;
        return converted;
    }
}

