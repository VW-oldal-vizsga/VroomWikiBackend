using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PastModel 
    {
        [Key]
        public required int Id { get; set; }

        [StringLength(50)]
        public required string? Name { get; set; }

       
        public string? Description { get; set; }

        public string? ImageBase64 { get; set; }

        [StringLength(40)]
        public required string? Engine { get; set; }

        public required string? Horsepower { get; set; }
        public required int? ReleaseDate { get; set; }

        public  List<string> Assembly { get; set; }

        public  string Designer { get; set; }
        public  string Design { get; set; }
        public  List<string> Production { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
