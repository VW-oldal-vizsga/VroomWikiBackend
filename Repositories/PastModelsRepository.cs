using Models;
using Newtonsoft.Json;
using VroomWiki.Data;

namespace VroomWiki.Repositories
{
    public class PastModelsRepository
    {
        private readonly AppDbContext context;
        public PastModelsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<PastModel> GetAll()
        {
            return context.Set<PastModel>().Where(p => !p.IsDeleted);
        }

        public IEnumerable<PastModel> GetOneModel(int id)
        {
            return context.Set<PastModel>().Where(p => p.Id==id);
        }

        public byte[] GetImage(int id)
        {
            var pastModel = context.Set<PastModel>().SingleOrDefault(p => p.Id == id && !p.IsDeleted);
            if (pastModel == null)
                return null!;
            return Convert.FromBase64String(pastModel.ImageBase64);
        }

        public PastModel AddPastModel(dynamic pastModel)
        {
            var entity = context.Set<PastModel>().Add(pastModel);
            context.SaveChanges();
            return entity.Entity;
        }

        public PastModel UpdatePastModel(int id, dynamic pastModelData)
        {
            var pastModel = context.Set<PastModel>().SingleOrDefault(p => p.Id == id);
            if (pastModel == null)
                throw new Exception("Model not found");
            PastModel newPastModel = JsonConvert.DeserializeObject<PastModel>(pastModelData.ToString());
            if (pastModel.Id != id)
                throw new Exception("Model id does not match");
            pastModel.Name = newPastModel.Name;
            pastModel.DescriptionHU = newPastModel.DescriptionHU;
            pastModel.Engine = newPastModel.Engine;
            pastModel.ReleaseDate = newPastModel.ReleaseDate;
            pastModel.Horsepower = newPastModel.Horsepower;
            if (!string.IsNullOrEmpty(newPastModel.ImageBase64))
                pastModel.ImageBase64 = newPastModel.ImageBase64;
            context.SaveChanges();
            return pastModel;
        }

        public void DeletePastModel(int pastModelId)
        {
            var pastModel = context.Set<PastModel>().SingleOrDefault(p => p.Id == pastModelId);
            if (pastModel == null)
                throw new Exception("Model not found");

            context.Set<PastModel>().Remove(pastModel);
            context.SaveChanges();
        }
    }
}
