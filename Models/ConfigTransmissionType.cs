﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ConfigTransmissionType
    {
        [Key]
        public required int Id { get; set; }

        [StringLength(40)]
        public required string? Name { get; set; }

        [StringLength(40)]
        public required string? WheelDrive { get; set; }
        public int Price { get; set; }

    }
}
