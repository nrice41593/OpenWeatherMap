using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json.Linq;


namespace OpenWeatherMap
{
    class WeatherAPI
    {
        public static string GetWeather(string zip, string country, string defaultKey)
        {

            var apiKey = JObject.Parse(defaultKey).GetValue("DefaultKey").ToString();
            var appID = "&appid=";
            var apiAddress = "https://api.openweathermap.org/data/2.5/weather?zip=" + zip + "," + country;
            var apiCall = $"{apiAddress}{appID}{apiKey}";

            var client = new HttpClient();
            var response = client.GetStringAsync(apiCall).Result;

            var currentWeather = JObject.Parse(response).GetValue("main").ToString();
            return currentWeather;
        }
    }
}
