using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Configuration
    {
        [Key]
        public required int Id { get; set; }

        [ForeignKey("User")]
        public required int User_Id { get; set; }
        public User User { get; set; }
       

    [StringLength(50)]
        public required string? ConfigName { get; set; }

        [ForeignKey("ConfigEngine")]
        public required int Engine_Id { get; set; }
        public ConfigEngine Engine { get; set; }
        

        public required int? Horsepower { get; set; }
        public int? YearProd { get; set; }

        [ForeignKey("ConfigColor")]
        public required int Color_Id { get; set; }
        public ConfigColor Color { get; set; }
        

        public required int? totalCost { get; set; }

        [StringLength(30)]
        public required string? VehicleType { get; set; }

        [ForeignKey("ConfigTransmissionType")]
        public required int TransmissionType_Id { get; set; }
        public ConfigTransmissionType TransmissionType { get; set; }

        [StringLength(25)]
        public required string? WheelDrive { get; set; }

        [StringLength(30)]
        public required string? WheelType { get; set; }

        [StringLength(20)]
        public required string? FuelConsumption { get; set; }

        public required float? Co2Emission { get; set; }
    } 
}
