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
            var serializer = new DataContractJsonSerializer(typeof(WeatherData));
            var streamTask = client.GetStreamAsync("https://api.darksky.net/forecast/dcd2262dfdbb2349f6e41e54e7a8d40a/41.443423,-81.775168?exclude=minutely,hourly");
            var weather = serializer.ReadObject(await streamTask) as WeatherData;
            return weather;
        }


        public static WeatherData ParseWeather()
        {
            var weather = CallDarkSky().Result;
            var direction = GetDirections(weather.currently.windBearing);
            Console.WriteLine($"Daily Summary: {weather.daily.summary}");
            Console.WriteLine($"Current Precip Probability: {weather.currently.precipProbability}");
            Console.WriteLine($"The current wind speed is: {weather.currently.windSpeed} mph with gusts up to {weather.currently.windGust} mph out of the {direction}");
            Console.WriteLine($"The nearest storm is {weather.currently.nearestStormDistance} miles away and moving to the {direction}");
            if (weather.alerts != null)
            {
                Console.WriteLine(ParseAlertData(weather.alerts));
            }
            else
            {
                Console.WriteLine("No alerts at this time");
            }
            
            return weather;
        }

        public static string ParseAlertData(List<Alerts> alerts)
        {
            if(alerts.Count > 0)
            {
                foreach (var alert in alerts)
                {
                    var alert_text = $"Current weather alert: {alert.alert_title} \t {alert.regions} \t {alert.alert_time} \t {alert.severity}";
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
        /*
        
            bool v = weather.alerts == null;
            if (v)
            {
                Console.WriteLine("No alerts");
                return weather;
            }
            else
            {
                Console.WriteLine(ParseAlertData().Result());
                return weather;
            }
        */

        public static string  GetDirections(double number)
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
    }
}