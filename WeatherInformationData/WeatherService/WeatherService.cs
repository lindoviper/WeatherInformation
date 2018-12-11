using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WeatherService.Model;
using System.Data.Entity;

namespace WeatherService
{

    public class WeatherService : IWeatherService
    {
        public WeatherService()
        {
            Database.SetInitializer<WeatherInfoDbContext>(null);
        }
        public WeatherInfo GetWeatherInfo(string value)
        {
            var dbContext = new WeatherInfoDbContext();
            var weatherInfo = dbContext.WeatherInfo.Where(x => x.City == value).FirstOrDefault();
            return new WeatherInfo() { City = value, Temperature = weatherInfo.Temperature, Forecast = weatherInfo.Forecast };
        }

        public void InsertWeatherInfo(WeatherInfo weather)
        {
            try
            {
                var dbContext = new WeatherInfoDbContext();
                dbContext.WeatherInfo.Add(weather);
                dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception($"Error while saving data. See details, Cannot insert duplicate records.");
            }
        }
    }
}
