using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Configuration
    {
        public required int Id { get; set; }
        public required User User_id { get; set; }

        [StringLength(50)]
        public required string? ConfigName { get; set; }

        public required ConfigEngine? Engine_id { get; set; }

        public required int? Horsepower { get; set; }
        public int? YearProd { get; set; }
        public required ConfigColor? Color_id { get; set; }
        public required int? totalCost { get; set; }

        [StringLength(30)]
        public required string? VehicleType { get; set; }

        public required ConfigTransmissionType? TransmissionTpye_id { get; set; }

        [StringLength(25)]
        public required string? WheelDrive { get; set; }

        [StringLength(30)]
        public required string? WheelType { get; set; }

        [StringLength(30)]
        public required string? CarpetType { get; set; }

        public required float? FuelConsumption { get; set; }

        [StringLength(20)]
        public required string? FuelType { get; set; }

        public required float? Co2Emission { get; set; }
    } 
}
