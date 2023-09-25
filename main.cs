using System;

class Program
{
    static void Main(string[] args)
    {
        // Declare a named constant for the number of centimeters in an inch
        const double CentimetersPerInch = 2.54;

        // Declare a variable to represent a measurement in inches and assign a value
        double inches = 5;

        // Calculate the measurement in centimeters
        double centimeters = inches * CentimetersPerInch;

        // Display the measurement in both inches and centimeters
        Console.WriteLine($"{inches} inches is {centimeters} centimeters");
    }
}
