using Models;
using VroomWiki.DTOs.Configs;

namespace VroomWiki.Mappers
{
    public static class ConfigEngineMappers
    {
        public static ConfigEngineDTO ToConfigEngineDTO(this ConfigEngine configEngine)
        {
            return new ConfigEngineDTO
            {
                Id = configEngine.Id,
                Name = configEngine.Name,
                Horsepower = configEngine.Horsepower,
                FuelConsumption = configEngine.FuelConsumption,
                Co2Emission = configEngine.Co2Emission,
                FuelType = configEngine.FuelType
            };
        }
    }
}
