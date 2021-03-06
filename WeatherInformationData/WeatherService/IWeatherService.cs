﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WeatherService
{
    [ServiceContract]
    public interface IWeatherService
    {
        [OperationContract]
        WeatherInfo GetWeatherInfo(string city);

        [OperationContract]
        void InsertWeatherInfo(WeatherInfo weather);

    }
}
