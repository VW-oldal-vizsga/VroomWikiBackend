using System.ComponentModel.DataAnnotations;

namespace VroomWiki.DTOs.MainPage
{
    public class SalesDTO
    {
        public required int Id { get; set; }
        public required int? Year { get; set; }
        public required float? TotalSale { get; set; }
        public required float? TotalIncome { get; set; }
    }
}
