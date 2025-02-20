using Models;
using VroomWiki.DTOs.Configs;
namespace VroomWiki.Mappers
{
    public static class ConfigTransTypesMappers
    {
        public static ConfigTransTypesDTO ToConfigTransTypesDTO(this ConfigTransmissionType configTransTypesDTO)
        {
            return new ConfigTransTypesDTO
            {
                Id = configTransTypesDTO.Id,
                Name = configTransTypesDTO.Name,
                WheelDrive = configTransTypesDTO.WheelDrive,
            };
        }
    }
}
