﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User 
    {
        [Key]
        public required int Id { get; set; }
        public string? Email { get; set; }

        public string? Password { get; set; }

        public string? Username { get; set; }

        public DateTime? CreatedAt { get; set; }
    }
}
