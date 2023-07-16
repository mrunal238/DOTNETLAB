using System;
namespace TemparatureConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureConverter temp = new TemperatureConverter();
            Console.Write("give celsius temparature for conversion :");
            string val1 = Console.ReadLine();
            double fahrenheit = temp.CelsiusToFahrenheit(val1);
            Console.WriteLine($"the value of {val1} celsius is {fahrenheit}fahrenheit");
        }
    }
}