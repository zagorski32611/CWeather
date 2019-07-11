using System.Linq;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace weatherapp
{
    [DataContract(Name="weatherData")]
    public class WeatherData
    {
        [DataMember]
        public double latitude { get; set; }
        [DataMember]
        public double longitude { get; set; }
        [DataMember]
        public string timezone { get; set; }
        [DataMember]
        public Currently currently { get; set; }
        [DataMember]
        public Daily daily { get; set; }
        [DataMember]
        public Flags flags { get; set; }
        [DataMember]
        public List<Alerts> alerts { get; set; }
        [DataMember]
        public int? offset { get; set; }

    }
    [DataContract(Name="currently")]
    public class Currently
    {
        [DataMember]
        public string time { get; set; }
        [DataMember]
        public string summary { get; set; }
        [DataMember]
        public string icon { get; set; }
        [DataMember]
        public double nearestStormDistance { get; set; }
        [DataMember]
        public double nearestStormBearing { get; set; }
        [DataMember]
        public double precipIntensity { get; set; }
        [DataMember]
        public double precipProbability { get; set; }
        [DataMember]
        public double temperature { get; set; }
        [DataMember]
        public double apparentTemperature { get; set; }
        [DataMember]
        public double dewPoint { get; set; }
        [DataMember]
        public double humidity { get; set; }
        [DataMember]
        public double pressure { get; set; }
        [DataMember]
        public double windSpeed { get; set; }
        [DataMember]
        public double windGust { get; set; }
        [DataMember]
        public double windBearing { get; set; }
        [DataMember]
        public double cloudCover { get; set; }
        [DataMember]
        public double uvIndex { get; set; }
        [DataMember]
        public double visibility { get; set; }
        [DataMember]
        public double ozone { get; set; }

    }
    [DataContract(Name="daily")]
    public class Daily
    {
        [DataMember]
        public string summary { get; set; }
        [DataMember]
        public string icon { get; set; }
        [DataMember]
        public List<Days> days { get; set; }

    }
    [DataContract(Name="Days")]
    public class Days
    {
        [DataMember]
        public string time { get; set; }
        [DataMember]
        public string summary { get; set; }
        [DataMember]
        public string icon { get; set; }
        [DataMember]
        public string sunriseTime { get; set; }
        [DataMember]
        public string sunsetTime { get; set; }
        [DataMember]
        public double moonPhase { get; set; }
        [DataMember]
        public double precipIntensity { get; set; }
        [DataMember]
        public double precipIntensityMax { get; set; }
        [DataMember]
        public string precipIntensityMaxTime { get; set; }
        [DataMember]
        public double precipProbability { get; set; }
        [DataMember]
        public string precipType { get; set; }
        [DataMember]
        public double temperatureHigh { get; set; }
        [DataMember]
        public string temperatureHighTime { get; set; }
        [DataMember]
        public double temperatureLow { get; set; }
        [DataMember]
        public string temperatureLowTime { get; set; }
        [DataMember]
        public double apparentTemperatureHigh { get; set; }
        [DataMember]
        public string apparentTemperatureHighTime { get; set; }
        [DataMember]
        public double apparentTemperatureLow { get; set; }
        [DataMember]
        public string apparentTemperatureLowTime { get; set; }
        [DataMember]
        public double dewPoint { get; set; }
        [DataMember]
        public double humidity { get; set; }
        [DataMember]
        public double pressure { get; set; }
        [DataMember]
        public double windSpeed { get; set; }
        [DataMember]
        public double windGust { get; set; }
        [DataMember]
        public string windGustTime { get; set; }
        [DataMember]
        public int windBearing { get; set; }
        [DataMember]
        public double cloudCover { get; set; }
        [DataMember]
        public int uvIndex { get; set; }
        [DataMember]
        public string uvIndexTime { get; set; }
        [DataMember]
        public double visibility { get; set; }
        [DataMember]
        public double ozone { get; set; }
        [DataMember]
        public double temperatureMin { get; set; }
        [DataMember]
        public string temperatureMinTime { get; set; }
        [DataMember]
        public double temperatureMax { get; set; }
        [DataMember]
        public string temperatureMaxTime { get; set; }
        [DataMember]
        public double apparentTemperatureMin { get; set; }
        [DataMember]
        public string apparentTemperatureMinTime { get; set; }
        [DataMember]
        public double apparentTemperatureMax { get; set; }
        [DataMember]
        public string apparentTemperatureMaxTime { get; set; }
    }


    [DataContract(Name="Flags")]
    public class Flags
    {
        [DataMember]
        public List<string> sources { get; set; }
        [DataMember]
        public string units { get; set; }
    }

[DataContract(Name="alerts")]
    public class Alerts
    {
        [DataMember]
        public string alert_title { get; set; }
        [DataMember]
        public List<string> regions { get; set; }
        [DataMember]
        public string severity { get; set; }
        [DataMember]
        public string alert_time { get; set; }

    }
}

/*
public class Minutely
    {
        public string summary { get; set; }
        public string icon { get; set; }
        public List<Datum> data { get; set; }
    }

    public class ExtendedData_Currently
    {
        public string time { get; set; }
        public string summary { get; set; }
        public string icon { get; set; }
        public double precipIntensity { get; set; }
        public double precipProbability { get; set; }
        public double temperature { get; set; }
        public double apparentTemperature { get; set; }
        public double dewPoint { get; set; }
        public double humidity { get; set; }
        public double pressure { get; set; }
        public double windSpeed { get; set; }
        public double windGust { get; set; }
        public int windBearing { get; set; }
        public double cloudCover { get; set; }
        public int uvIndex { get; set; }
        public double visibility { get; set; }
        public double ozone { get; set; }
        public string precipType { get; set; }
    }

    public class Hourly
    {
        public string summary { get; set; }
        public string icon { get; set; }
        public List<Datum> data { get; set; }
    }

     */
