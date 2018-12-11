using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WeatherService.Model
{
    public class WeatherInfoDbContext : DbContext
    {
        public DbSet<WeatherInfo> WeatherInfo { get; set; }

        public WeatherInfoDbContext() : base(@"Server =lindo-mbuthuma\SQLEXPRESS;Initial catalog=Weather;Trusted_Connection=True;")
        {

        }
    }
}
