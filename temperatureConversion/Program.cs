/*
 * Filename: temperatureConversion
 * Author: gravitypixelinfinitex
 * Description: version 1 - Testing conversion from Celcius to Farenheit and vice versa
 */

// Input message to the user to select a type of conversion
Console.WriteLine("Please enter 'CF' and hit enter to convert a temperature from Celcius to Fraenheit \n Please enter 'FC' and hit enter to convert a temperature from Farenheit to Celcius");
string input = Console.ReadLine();
Console.Clear();

// If statement to the user to input a proper request
if (input == "CF" || input == "cf")
{
    Console.WriteLine("Please enter a temperature in degrees Celcius that is a whole number and hit enter to convert to degrees Farenheit");
    try
    {
        int myValue = int.Parse(Console.ReadLine());
        double farenheitvalue =  Convert.ToDouble(myValue) * 9 / 5 + 32;
        Console.WriteLine("Your temperature is: " + Math.Round(farenheitvalue, 1) + " in Farenheit Degrees");
    }
    catch (Exception)
    {
        Console.WriteLine("You tried to input an unvalid value"); // Output to the user to convert from celcius to Farenheit
    }
}
if (input == "FC" || input == "fc")
{
    Console.WriteLine("Please enter a temperature in degrees Farenheit that is a whole number and hit enter to convert to degrees Celcius");
    try
    {
        int myValue = int.Parse(Console.ReadLine());
        double celciusvalue = Convert.ToDouble(myValue - 32) * 5 / 9;
        Console.WriteLine("Your temperature is " + Math.Round(celciusvalue,1) + " in Celcius Degrees");
    }
    catch (Exception)
    {
        Console.WriteLine("You tried to input an unvalid value"); // Output to the user to convert from Farenheit to Celcius
    }
}
else if (input == "FP")
{
    Console.WriteLine("INVALID MENU ITEM!! PLEASE INPUT FC OR CF AT NEXT PROGRAM RUN");
}

