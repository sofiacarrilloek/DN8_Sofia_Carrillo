﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Entities
{
    public class ZoneWeatherForecast
    {
        public Zone Zone { get; set; }

        public IEnumerable<WeatherForecast>WeatherForecast { get; set; }

       
    }
}
