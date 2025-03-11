using System.ComponentModel.DataAnnotations;

namespace VroomWiki.Models
{
    public class MainPageHistory
    {
        [Key]
        public required int Id { get; set; }

        public string? Title { get; set; }
        public string? History { get; set; }
    }
}
