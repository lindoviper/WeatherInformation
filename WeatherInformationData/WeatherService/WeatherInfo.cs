using System.Runtime.Serialization;
using System.ServiceModel;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WeatherService
{
    [DataContract]
    [Table("WeatherInfo")]
    public class WeatherInfo
    {
        [DataMember]
        [Key]
        public string City { get; set; }

        [DataMember]
        [Required]
        public int Temperature { get; set; }

        [DataMember]
        public string Forecast { get; set; }
    }
}