using System.ComponentModel.DataAnnotations;

namespace VroomWiki.DTOs.MainPage
{
    public class MainPageDTO
    {
        public required int Id { get; set; }
        public string? Description { get; set; }
        public required int? Founded { get; set; }
        public string? Headquarters { get; set; }
        public string? Factories { get; set; }
        public required string? Chairman { get; set; }
        public required string? Owner { get; set; }
        public string? Products { get; set; }
        public int? Employees { get; set; }
        public string? History { get; set; }
        public string? Profit { get; set; }
    }
}
