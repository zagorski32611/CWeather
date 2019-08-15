using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace weatherapp
{
    class Forecast
    {
        public static string Next7Days()
        {
            using (var db = new WeatherContext())
            {
                var sevenDays = (from d in db.Days
                .OrderByDescending (d => d.Days_Id)
                select d).Take(7);

                Console.WriteLine($"The next seven days:\r\n");

                foreach(var day in sevenDays)
                {
                    Console.WriteLine($"{WeatherRR.GetDateTime(day.time)} \r\n {day.apparentTemperatureHigh} \r\n {day.apparentTemperatureLow}");
                } 
            }
            return "";
        }
    }
}