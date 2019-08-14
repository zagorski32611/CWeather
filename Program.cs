﻿using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace weatherapp
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool exitCode = false;
            
            Console.WriteLine("Welcome to the Weather App.");
            Console.WriteLine(System.Environment.NewLine);

            while (!exitCode)
            {
                Console.WriteLine("\n Please Select an option:");
                Console.WriteLine("1: Current Weather \t 2: 7 Day Forecast \t 3: Historical Weather (in development) \t e: exit the program");
                var input = Console.ReadLine();
                if (input == "1")
                {
                    WeatherRR.ParseWeather();
                }
                else if (input == "2")
                {
                    Forecast.Next7Days();       
                }
                else if (input == "3")
                {
                    HistoricalData.HistoricalDataMenu();
                }
                else if (input == "e")
                {
                    Console.WriteLine("exiting...");
                    exitCode = true;
                }
                else
                {
                    Console.WriteLine("Eh, I don't recognize that option \n");
                }
            }
        }
    }
}