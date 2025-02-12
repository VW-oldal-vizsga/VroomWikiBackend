using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ConfigTransmissionType
    {
        public required int Id { get; set; }

        [StringLength(20)]
        public required string? Name { get; set; }

        [StringLength(20)]
        public required string? WheelDrive { get; set; }
    }
}
