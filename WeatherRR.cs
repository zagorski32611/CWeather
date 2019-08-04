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
        public static async Task CallDarkSkyTest()
        {
            var stringTask = client.GetStringAsync("https://api.darksky.net/forecast/dcd2262dfdbb2349f6e41e54e7a8d40a/41.443423,-81.775168?exclude=minutely");
            var msg = await stringTask;
            Console.Write(msg.ToString());
        }

        public static async Task<WeatherData> CallDarkSky()
        {
            //var serializer = new DataContractJsonSerializer(typeof(WeatherData));
            var weather = new WeatherData();

            try
            {
                //var streamTask = await client.GetStreamAsync("https://api.darksky.net/forecast/dcd2262dfdbb2349f6e41e54e7a8d40a/41.443423,-81.775168?exclude=minutely,hourly"))
                HttpResponseMessage responseMessage = await client.GetAsync("https://api.darksky.net/forecast/dcd2262dfdbb2349f6e41e54e7a8d40a/41.443423,-81.775168?exclude=minutely,hourly");
                responseMessage.EnsureSuccessStatusCode();
                string responseBody = await responseMessage.Content.ReadAsStringAsync();
                WeatherData deserializedWeatherData = JsonConvert.DeserializeObject<WeatherData>(responseBody);
                return deserializedWeatherData;
                
            }
            catch(Exception e)
            {
                Console.WriteLine($"Cannot reach dark sky. {e}");
                return weather;
            }
        }


        public static WeatherData ParseWeather()
        {
            var weather = CallDarkSky().Result;
            var direction = GetDirections(weather.currently.windBearing);
            Console.WriteLine($"Daily Summary: {weather.daily.summary}");
            Console.WriteLine($"Current Precip Probability: {weather.currently.precipProbability}");
            Console.WriteLine($"The current wind speed is: {weather.currently.windSpeed} mph with gusts up to {weather.currently.windGust} mph out of the {direction}");
            Console.WriteLine($"The nearest storm is {weather.currently.nearestStormDistance} miles away and moving to the {direction}");


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
                db.Add(weather);
            }
            return weather;
        }

        private static WeatherData NewMethod()
        {
            var weather = CallDarkSky().Result;
            var direction = GetDirections(weather.currently.windBearing);
            Console.WriteLine($"Daily Summary: {weather.daily.summary}");
            Console.WriteLine($"Current Precip Probability: {weather.currently.precipProbability}");
            Console.WriteLine($"The current wind speed is: {weather.currently.windSpeed} mph with gusts up to {weather.currently.windGust} mph out of the {direction}");
            Console.WriteLine($"The nearest storm is {weather.currently.nearestStormDistance} miles away and moving to the {direction}");

            return weather;
        }

        public static string ParseAlertData(List<Alerts> alerts)
        { 
            // There's probably a better way to do this...
            if(alerts.Count > 0)
            {
                foreach (var alert in alerts)
                {
                    var alert_text = $"Current weather alert: {alert.alert_title} \t {alert.region} \t {alert.alert_time} \t {alert.severity}";
                    Console.WriteLine(alert_text);
                    return alert_text;
                }
            }
            else
            {
                return "No alerts at this time";
            }
            return "";
        }

        public static string GetDirections(double number)
        {
            if( 22.5 < number || number <= 67.5)
            {
                return "North East";
            } 
            else if ( 67.5 < number || number <= 112.5 )
            {
                return "East";
            }
            else if ( 112.5 < number || number <= 157.5 ) 
            {
                return "South East";
            }
            else if ( 157.5 < number || number <= 202.5 )
            {
                return "South";
            }
            else if ( 202.5 < number || number <= 247.5 )
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
                //        using (var streamTask = await client.GetStreamAsync("https://api.darksky.net/forecast/dcd2262dfdbb2349f6e41e54e7a8d40a/41.443423,-81.775168?exclude=minutely,hourly"))
                //{
                //    WeatherData deserializedWeatherData = JsonConvert.DeserializeObject<WeatherData>(streamTask.ToString());
                //    return deserializedWeatherData;
                //}
    }
}