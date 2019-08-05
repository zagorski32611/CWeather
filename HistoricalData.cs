using System;
using System.Collections.Generic;
using System.Linq;

namespace weatherapp
{
    class HistoricalData
    {
        public HistoricalData()
        {
        }

        public static List<char> ReadData()
        {
            var weather = new WeatherData();

            var currently = weather.currently.time                          
                                    .Where(s => s.ToString() != DateTime.Now.ToString())
                                    .ToList();
            return currently;
        }
    }
}