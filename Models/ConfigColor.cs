using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ConfigColor
    {
        [Key]
        public required int Id { get; set; }

        [StringLength(20)]
        public string? Name { get; set; }
        public string? ImageBase64 { get; set; }
        public int Price { get; set; }
        public string ColorCode { get; set; }

    }
}
