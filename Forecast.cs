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
            var CurrentTime = DateTime.Now;
            using (var db = new WeatherContext())
            {
                var sevenDays = (from d in db.Days
                orderby d.Days_Id
                select d).Take(7);

                foreach(var day in sevenDays)
                {
                    Console.WriteLine($"{day.apparentTemperatureHigh} \r\n {day.apparentTemperatureLow}");
                } 
            }
            return "";
        }
    }
}