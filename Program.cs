﻿using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace weatherapp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitCode = false;
            
            Console.WriteLine("Welcome to the Weather App.");

            while (!exitCode)
            {
                Console.WriteLine("\n Please Select an option:");
                Console.WriteLine("1: Current Weather \t 2: Historical Weather (in development) \t e: exit the program");
                var input = "1"; //Console.ReadLine();
                if (input == "1")
                {
                    WeatherRR.ParseWeather();
                }
                else if (input == "2")
                {
                    
                    HistoricalData.ReadData();
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