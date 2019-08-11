using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace weatherapp
{
    class HistoricalData
    {
        public static void HistoricalDataMenu()
        {
            bool exitCode = false;

            Console.WriteLine("Historical Data Menu \r\n Please select an option.");

            while (!exitCode)
            {
                Console.WriteLine("\n Please Select an option:");
                Console.WriteLine("1: Temprature Search \t 2: Another Report \t r: Return to Main Menu \t e: exit the program");
                var input = Console.ReadLine();
                if (input == "1")
                {
                    HistoricalData.TempratureSearch();
                }
                else if (input == "2")
                {
                    Console.WriteLine("Still working on it");
                }
                else if (input == "r")
                {
                    Console.WriteLine("Returning");

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


        public static string TempratureSearch()
        {
            Console.WriteLine("Search for high tempratures above or below your input. Enter in the temp you'd like to search for, then choose above or below");

            Console.WriteLine("Enter temprature as an intger");

            var searchTemp = Console.ReadLine();

            Console.WriteLine("higher or lower?");

            var higherLower = Console.ReadLine();

            using (var db = new WeatherContext())
            {
                if (higherLower == "higher")
                {
                    var highTempratures = db.Days
                        .Where(d => d.temperatureMax >= Convert.ToDouble(searchTemp));

                    Console.WriteLine($"The high temps above {searchTemp} are:");

                    foreach (var temps in highTempratures)
                    {
                        Console.WriteLine($"High: {temps.temperatureMax} Date: {WeatherRR.GetDateTime(temps.temperatureMaxTime)}");
                    }
                }
                else if (higherLower == "lower")
                {
                    var lowTempratures = db.Days
                        .Where(d => d.temperatureMax <= Convert.ToDouble(searchTemp));

                    Console.WriteLine($"The high temps below {searchTemp} are:");

                    foreach (var temps in lowTempratures)
                    {
                        Console.WriteLine($"High: {temps.temperatureMax} Date: {WeatherRR.GetDateTime(temps.temperatureMaxTime)}");
                    }
                }
                return "Found all";
            }
        }




        public static List<char> ReadData()
        {
            var weather = new WeatherData();

            var currently = weather.currently.time
                                    .Where(s => s.ToString() != DateTime.Now.ToString())
                                    .ToList();
            return currently;
        }

        public List<Days> highestTemp()
        {

            using (var db = new WeatherContext())
            {
                return (
                    from tp in db.Weather
                    from i in tp.daily.data
                    where i.apparentTemperatureHigh >= 75
                    select i
                ).ToList();
            }
        }

        private static object await(IQueryable<WeatherData> queryable)
        {
            throw new NotImplementedException();
        }
    }
}

/*
            //var daily_weather = 
            
            // Define the query expression.
            
            var tempratures =
                 (from temps in db.Weather
                    from x in temps.daily.data
                        where x.apparentTemperatureHigh >= 0
                        select temps).ToList();

            foreach (var i in tempratures)
            {
                Console.WriteLine($"{i}");
            }
            return tempratures;
*/
