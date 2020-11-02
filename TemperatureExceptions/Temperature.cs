using System;
namespace TemperatureExceptions
{
    public class Temperature
    {

        private double fahrenheit;
        public static double AbsoluteZeroFahrenheit { get; } = -459.67;

        public Temperature(double fahrenheit) // added try catch and finally
        {
            try
            {
                Fahrenheit = fahrenheit;
            }
            catch (ArgumentOutOfRangeException e) // e did not use here, if we remove e still works. do not know why?
            {
                Fahrenheit = -459.67;
            }
            finally
            {
                Console.WriteLine("Fahrenheit cannot be less than -459.67.");
            }
        }

        public double Fahrenheit
        {
            get
            {
                return fahrenheit;
            }
            set
            {

                if (value < AbsoluteZeroFahrenheit)
                {
                    throw new ArgumentOutOfRangeException("Value is below absolute zero");
                }

                fahrenheit = value;
            }
        }

    }
}
