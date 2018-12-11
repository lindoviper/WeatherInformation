using System.Runtime.Serialization;
using System.ServiceModel;
namespace WeatherService
{
    [DataContract]
    public class WeatherInfo
    {
        [DataMember]
        public string City { get; set; }

        [DataMember]
        public int Temperature { get; set; }

        [DataMember]
        public string Forecast { get; set; }
    }
}