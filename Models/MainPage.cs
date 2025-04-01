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

        public string DescriptionHU { get; set; }
        public string DescriptionEN { get; set; }
        public string DescriptionDU { get; set; }

        public required int? Founded { get; set; }

        [StringLength(40)]
        public string? Headquarters { get; set; }

        [StringLength(50)]
        public string Factories { get; set; }

        [StringLength(30)]
        public required string? Chairman { get; set; }

        public string? ImageBase64Chairman { get; set; }
        public string? ImageBase64Bratislava { get; set; }
        public string? ImageBase64Wolfsburg { get; set; }
        public string? ImageBase64Dresden { get; set; }

        [StringLength(30)]
        public required string? Owner { get; set; }

        public string Products { get; set; }
        public int? Employees { get; set; }
        public string? Profit { get; set; }
        public string? ImageBase64 { get; set; }
    }
}
