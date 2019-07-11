using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace weatherapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Weather App.");
            Console.WriteLine("Please Select an option:");
            Console.WriteLine("1: Current Weather \t 2: Historical Weather (in development)");
            var input = "1"; //Console.ReadLine();
            if (input == "1")
            {
                WeatherRR.ParseWeather();
            }
            else if (input == "2")
            {
                Console.WriteLine("Sorry, this feature is under development \t Please select an option lol");
                // call menu function
            }
            else
            {
                Console.WriteLine("Eh, I don't recognize that option");
                // call menu function
            }
        }
    }
}

