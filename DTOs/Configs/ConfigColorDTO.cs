using System.ComponentModel.DataAnnotations;

namespace VroomWiki.DTOs.Configs
{
    public  class ConfigColorDTO
    {
        public required int Id { get; set; }
        public string? Name { get; set; }
    }
}
