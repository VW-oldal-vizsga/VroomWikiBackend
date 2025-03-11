using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MainPage
    {
        [Key]
        public required int Id { get; set; }

        public string? Description { get; set; }

        public required int? Founded { get; set; }

        [StringLength(40)]
        public string? Headquarters { get; set; }

        [StringLength(50)]
        public string? Factories { get; set; }

        [StringLength(30)]
        public required string? Chairman { get; set; }

        [StringLength(30)]
        public required string? Owner { get; set; }

        public string? Products { get; set; }
        public int? Employees { get; set; }
        public string? Profit { get; set; }
        public string? ImageBase64 { get; set; }
    }
}
