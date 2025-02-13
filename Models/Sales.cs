using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Sale 
    {
        [Key]
        public required int Id { get; set; }
        public required int? Year { get; set; }
        public required float? TotalSale { get; set; }
        public required float? TotalIncome { get; set; }
    }
}
