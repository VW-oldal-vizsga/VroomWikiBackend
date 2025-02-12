using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ConfigEngine
    {
        public required int Id { get; set; }

        [StringLength(20)]
        public required string? Name { get; set; }
        public required int Horsepower { get; set; }
        public required float FuelConsumption { get; set; }
        public required float Co2Emission { get; set; }

        [StringLength(20)]
        public required string? FuelType { get; set; }
    }
}
