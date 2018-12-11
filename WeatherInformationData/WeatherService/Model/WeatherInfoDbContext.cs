using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Configuration;

namespace WeatherService.Model
{
    public class WeatherInfoDbContext : DbContext
    {
        public DbSet<WeatherInfo> WeatherInfo { get; set; }

        public WeatherInfoDbContext() : base(ConfigurationManager.AppSettings["connectionString"])
        {

        }
    }
}
