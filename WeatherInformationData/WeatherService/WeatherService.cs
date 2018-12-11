using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WeatherService
{

    public class WeatherService : IWeatherService
    {
        public WeatherInfo GetWeatherInfo(string value)
        {
            return new WeatherInfo() { City = value, Temperature = 20, Forecast = "Rainy" };
        }
    }
}
