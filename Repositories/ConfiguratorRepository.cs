using Models;
using Newtonsoft.Json;
using VroomWiki.Data;

namespace VroomWiki.Repositories
{
    public class ConfiguratorRepository
    {
        private readonly AppDbContext context;
        public ConfiguratorRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Configuration> GetAllConfigs()
        {
            return context.Set<Configuration>();
        }

        public IEnumerable<Configuration> GetOneConfiguration(int id)
        {
            return context.Set<Configuration>().Where(p => p.Id == id);
        }

        public byte[] GetImageConfig(int id)
        {
            var configuration = context.Set<Configuration>().SingleOrDefault(p => p.Id == id);
            if (configuration == null)
                return null!;
            return Convert.FromBase64String(configuration.ImageBase64);
        }

        public IEnumerable<ConfigColor> GetAllColor()
        {
            return context.Set<ConfigColor>();
        }

        public IEnumerable<ConfigColor> GetOneColor(int id)
        {
            return context.Set<ConfigColor>().Where(p => p.Id == id);
        }

        public byte[] GetImageColor(int id)
        {
            var configColor = context.Set<ConfigColor>().SingleOrDefault(p => p.Id == id);
            if (configColor == null)
                return null!;
            return Convert.FromBase64String(configColor.ImageBase64);
        }

        public IEnumerable<ConfigEngine> GetAllEngines()
        {
            return context.Set<ConfigEngine>();
        }

        public IEnumerable<ConfigEngine> GetOneEngine(int id)
        {
            return context.Set<ConfigEngine>().Where(p => p.Id == id);
        }

        public IEnumerable<ConfigTransmissionType> GetAllTransmissions()
        {
            return context.Set<ConfigTransmissionType>();
        }

        public IEnumerable<ConfigTransmissionType> GetOneTransmission(int id)
        {
            return context.Set<ConfigTransmissionType>().Where(p => p.Id == id);
        }

        public Configuration AddConfiguration(dynamic configurator)
        {
            var entity = context.Set<Configuration>().Add(configurator);
            context.SaveChanges();
            return entity.Entity;
        }

        public Configuration UpdateConfiguration(int id, dynamic configuratorData)
        {
            var configurator = context.Set<Configuration>().SingleOrDefault(p => p.Id == id);
            if (configurator == null)
                throw new Exception("Model not found");
            Configuration newConfigurator = JsonConvert.DeserializeObject<Configuration>(configuratorData.ToString());
            if (configurator.Id != id)
                throw new Exception("Model id does not match");
            configurator.ConfigName = newConfigurator.ConfigName;
            configurator.Engine_Id = newConfigurator.Engine_Id;
            configurator.TransmissionType_Id = newConfigurator.TransmissionType_Id;
            configurator.User_Id = newConfigurator.User_Id;
            configurator.Color_Id = newConfigurator.Color_Id;
            context.SaveChanges();
            return configurator;
        }

        public void DeleteConfiguration(int configuratorId)
        {
            var configurator = context.Set<Configuration>().SingleOrDefault(p => p.Id == configuratorId);
            if (configurator == null)
                throw new Exception("Model not found");

            context.Set<Configuration>().Remove(configurator);
            context.SaveChanges();
        }
    }
}
