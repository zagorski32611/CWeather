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
            using (var db = new WeatherContext())
            {
                bool exitCode = false;

                Console.WriteLine("Historical Data Menu \r\n Please select an option.");

                while (!exitCode)
                {
                    Console.WriteLine("\n Please Select an option:");
                    Console.WriteLine("1: Temprature Search \t 2: Another Report \t 3: Insertion Sort algorithm \t r: Return to Main Menu \t e: exit the program");
                    var input = Console.ReadLine();
                    if (input == "1")
                    {
                        HistoricalData.TempratureSearch();
                    }
                    else if (input == "2")
                    {
                        Console.WriteLine("Still working on it");
                    }
                    else if (input == "3")
                    {
                        Console.WriteLine("The insertion sort");
                        
                        List<Days> unsortedDays = db.Days.ToList();

                        List<Days> sortedDays = HistoricalData.manualSortAlgo(unsortedDays);

                        //Console.WriteLine($"Unsorted -- Lowest: {unsortedDays[0].apparentTemperatureHigh}, Highest: {unsortedDays}");

                        Console.WriteLine($"Sorted -- Lowest: {sortedDays.First().apparentTemperatureHigh}, Highest: {sortedDays.Last().apparentTemperatureHigh}");
                        
                        //foreach (var day in unsortedDays)
                        //{
                        //    Console.WriteLine($"Temprature: {day.temperatureHigh} \n {day.time}");
                        //}
                        //foreach (var day in sortedDays)
                        //{
                        //    Console.WriteLine($"Temprature: {day.temperatureHigh} \n {day.time}");
                        //}
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

        public void highestTemp()
        {

            using (var db = new WeatherContext())
            {

                List<Days> days = (
                    from tp in db.Weather
                    from i in tp.daily.data
                    select i
                ).ToList();
            }
        }

        public static List<Days> manualSortAlgo(List<Days> days)
        {
            // This is an insertion sort algorithm.
            double tempCompare;
            
            int listSize = days.Count();

            for(int forSearchIndex = 1; forSearchIndex <= listSize -1; forSearchIndex++)
            {
                tempCompare = days[forSearchIndex].apparentTemperatureHigh;

                int whileSearchIndex = forSearchIndex;

                while(whileSearchIndex > 0 && days[whileSearchIndex - 1].apparentTemperatureHigh >= tempCompare)
                {
                    days[whileSearchIndex] = days[whileSearchIndex - 1];
                    whileSearchIndex -= 1;
                }
                days[whileSearchIndex].apparentTemperatureHigh = tempCompare;
            }
            return days;
        }


        public void InsertionSort(int[] arr)
        {
            int inner;
            int temp;
            int arrSize = arr.GetLength(0);

            for (int outer = 1; outer <= arrSize - 1; outer++)
            {
                temp = arr[outer];
                inner = outer;
                while (arr[inner - 1] >= temp)
                {
                    arr[inner] = arr[inner - 1];
                    inner -= 1;
                }
                arr[inner] = temp;
            }
        }










        private static object await(IQueryable<WeatherData> queryable)
        {
            throw new NotImplementedException();
        }
    }
}