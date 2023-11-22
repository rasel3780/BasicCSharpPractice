using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    internal class Temperature
    {
       
        public double ConvertCelsiusToFahrenheit(double temperature)
        {
            return temperature * (9.0 / 5) + 32;

        }

        public double ConvertFahrenheitToCelsius(double temperature) 
        {
            return (temperature - 32) * (5.0 / 9);
            
        }

        public string GetFeeling(double temperatureInCelsius)
        {
           
            if(temperatureInCelsius <= -1)
            {
                return "Extremely cold";
            }

            else if(temperatureInCelsius >= 0 && temperatureInCelsius<11) 
            {
                return "Very Cold";
            }

            else if (temperatureInCelsius >= 11 && temperatureInCelsius < 16)
            {
                return "Cold";
            }

            else if (temperatureInCelsius >= 16 && temperatureInCelsius < 26)
            {
                return "Warm";
            }

            else if (temperatureInCelsius >= 26 && temperatureInCelsius < 31)
            {
                return "Hot";
            }

            else if (temperatureInCelsius >= 31 && temperatureInCelsius < 46)
            {
                return "Very Hot";
            }

            else 
            {
                return "Extremely Hot";
            }
        }
    }
}
