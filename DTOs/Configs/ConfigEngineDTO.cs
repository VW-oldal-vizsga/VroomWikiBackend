using System.ComponentModel.DataAnnotations;

namespace VroomWiki.DTOs.Configs
{
    public class ConfigEngineDTO
    {
        public required int Id { get; set; }
        public required string? Name { get; set; }
        public required int Horsepower { get; set; }
        public required float FuelConsumption { get; set; }
        public required float Co2Emission { get; set; }
        public required string? FuelType { get; set; }
    }
}
