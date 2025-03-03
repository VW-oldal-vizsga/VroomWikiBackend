using Models;
using VroomWiki.DTOs.PastModels;

namespace VroomWiki.Mappers
{
    public static class PastModelsMappers
    {
        public static PastModelsDTO ToPastModelsDTO(this PastModel pastModels)
        {
            return new PastModelsDTO
            {
                Id = pastModels.Id,
                ModelName = pastModels.Name,
                Image = pastModels.ImageBase64
            };
        }
    }
}
