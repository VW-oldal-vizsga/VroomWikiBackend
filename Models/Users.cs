﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string? Username { get; set; }

        [NotMapped]
        public string? Password { get; set; }
        public string? PasswordHash { get; set; } = null;

        public DateTime? CreatedAt { get; set; }
    }
}
