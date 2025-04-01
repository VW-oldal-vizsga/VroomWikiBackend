using System.ComponentModel.DataAnnotations;

namespace VroomWiki.Models
{
    public class MainPageHistory
    {
        [Key]
        public required int Id { get; set; }

        public string? Title { get; set; }
        public string? TitleEN { get; set; }
        public string? TitleDU { get; set; }
        public string? History { get; set; }
        public string? HistoryEN { get; set; }
        public string? HistoryDU { get; set; }
        public string? History2 { get; set; }
        public string? History2EN { get; set; }
        public string? History2DU { get; set; }
        public string? History3 { get; set; }
        public string? History3EN { get; set; }
        public string? History3DU { get; set; }
    }
}
