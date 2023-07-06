using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityHW.models
{
    public class ForecastHistory
    {
        [Key]
        public int Id { get; set; }
        public string Icon { get; set; }
        public string CityName { get; set; }
        public double Temp { get; set; }
        public int Humidity { get; set; }
        public double FeelsLike { get; set; }

        public double WindSpeed { get; set; }

        public double Pressure { get; set; }

    }
}

