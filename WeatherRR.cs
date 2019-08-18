using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;

namespace weatherapp
{
    class WeatherRR
    {
        private static readonly HttpClient client = new HttpClient();
        public static async Task<WeatherData> CallDarkSky()
        {
            var weather = new WeatherData();

            try
            {
                HttpResponseMessage responseMessage = await client.GetAsync("https://api.darksky.net/forecast/dcd2262dfdbb2349f6e41e54e7a8d40a/41.443423,-81.775168?exclude=minutely,hourly");
                responseMessage.EnsureSuccessStatusCode();
                string responseBody = await responseMessage.Content.ReadAsStringAsync();
                WeatherData deserializedWeatherData = JsonConvert.DeserializeObject<WeatherData>(responseBody);
                return deserializedWeatherData;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Cannot reach dark sky. {e}");
                return weather;
            }
        }

        public static WeatherData ParseWeather()
        {
            var weather = CallDarkSky().Result;
            var direction = GetDirections(weather.currently.windBearing);

            Console.WriteLine($"The current temprature is {weather.currently.temperature} with a dew point of {weather.currently.dewPoint} and humidity of {weather.currently.humidity}");
            Console.WriteLine($"Daily Summary: {weather.daily.summary}");
            Console.WriteLine($"Current Precip Probability: {weather.currently.precipProbability}");
            Console.WriteLine($"The current wind speed is: {weather.currently.windSpeed} mph with gusts up to {weather.currently.windGust} mph out of the {direction}");
            Console.WriteLine($"The nearest storm is {weather.currently.nearestStormDistance} miles away and moving to the {direction}");
            Console.WriteLine(value: $"Almanac information: \r\n Sunrise: {GetDateTime(weather.daily.data[0].sunriseTime)} \r\n Sunset: {GetDateTime(weather.daily.data[0].sunsetTime)}");
            Console.WriteLine(value: $"\r\n Moon Phase: {weather.daily.data[0].moonPhase}");


            // cloud cover, visibility, wind direction,  
            if (weather.alerts != null)
            {
                Console.WriteLine(ParseAlertData(weather.alerts));

            }
            else
            {
                Console.WriteLine("No alerts at this time");
            }

            using (var db = new WeatherContext())
            {
                //db.Add(weather);
                db.Weather.Add(entity: weather);
                db.SaveChanges();
            }
            return weather;
        }

        public static string ParseAlertData(List<Alerts> alerts)
        {
            // There's probably a better way to do this...
            if (alerts.Count > 0)
            {
                AlertLoop(alerts);
            }
            else
            {
                return "\r\n No alerts at this time";
            }
            return "";
        }

        private static void AlertLoop(List<Alerts> alertdata)
        {
            var counter = alertdata.Count;
            foreach (var i in alertdata)
            {
                for (var b = 1; b < counter; b++)
                {
                    Console.WriteLine($"{i.data[b].alert_title}");
                }
            }
        }


        private static string GetDirections(double number)
        {
            if (22.5 < number || number <= 67.5)
            {
                return "North East";
            }
            else if (67.5 < number || number <= 112.5)
            {
                return "East";
            }
            else if (112.5 < number || number <= 157.5)
            {
                return "South East";
            }
            else if (157.5 < number || number <= 202.5)
            {
                return "South";
            }
            else if (202.5 < number || number <= 247.5)
            {
                return "South West";
            }
            else if (247.5 < number || number <= 302.5)
            {
                return "West";
            }
            else if (302.5 < number || number <= 347.5)
            {
                return "Noth West";
            }
            else if (447.5 < number || number <= 360)
            {
                return "North";
            }
            else if (0 <= number || number < 22.5)
            {
                return "North";
            }
            else
            {
                return "";
            }
        }

        public static DateTime GetDateTime(string unixTimeStamp)
        {
            DateTime unixStart = new DateTime(1970, 1, 1, 0, 0, 0, 0, kind: System.DateTimeKind.Utc);
            long longTime = long.Parse(unixTimeStamp);
            long unixTimeStampInTicks = (long)(longTime * TimeSpan.TicksPerSecond);

            DateTime dateTime = new DateTime(ticks: unixStart.Ticks + unixTimeStampInTicks, kind: System.DateTimeKind.Utc);
            return dateTime.ToLocalTime();
        }
    }
}