using System.ComponentModel.DataAnnotations;

namespace VroomWiki.DTOs.Configs
{
    public class ConfigTransTypesDTO
    {
        public required int Id { get; set; }
        public required string? Name { get; set; }
        public required string? WheelDrive { get; set; }
    }
}
