using Newtonsoft.Json.Linq;
using System.Net.Http;
using System;
using System.Runtime.InteropServices;

namespace OpenWeatherMap
{
    class Program
    {
        static void Main(string[] args)
        {
            var defaultKey = System.IO.File.ReadAllText("appsettings.json");
            Console.Write("Please enter your Zipcode: ");
            var zip = Console.ReadLine();
            Console.Write("Please enter your Country Code: ");
            var country = Console.ReadLine();

            var weather = WeatherAPI.GetWeather(zip, country, defaultKey);
            Console.WriteLine(weather);
        }
    }
}
