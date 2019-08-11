using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace weatherapp
{
    class HistoricalData
    {
        public void ReadHistoricalData()
        {
            Console.WriteLine($"{highestTemp()}");
        }


        public static string Linq101()
        {
            using (var db = new WeatherContext())
            {
                var tempratures = db.Currently
                    .Where(t => t.apparentTemperature >= 70);

                foreach (var loopvar1 in tempratures)
                {
                    Console.WriteLine($"{loopvar1.apparentTemperature}, {WeatherRR.GetDateTime(loopvar1.time)}");
                }
                return tempratures.ToString();
                //var saved_days = db.Weather.First().currently.apparentTemperature;

                //Console.WriteLine($"{saved_days}");    
                    
                //return saved_days.ToString();
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