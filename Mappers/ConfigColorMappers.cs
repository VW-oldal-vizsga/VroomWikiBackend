using Models;
using VroomWiki.DTOs.Configs;

namespace VroomWiki.Mappers
{
    public static class ConfigColorMappers
    {
        public static ConfigColorDTO ToConfigColorDTO(this ConfigColor configColor)
        {
            return new ConfigColorDTO
            {
                Id = configColor.Id,
                Name = configColor.Name
            };
        }
    }
}
