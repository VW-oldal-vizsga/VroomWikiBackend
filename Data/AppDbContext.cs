using Microsoft.EntityFrameworkCore;
using Models;
using Newtonsoft.Json;

namespace WebApplication1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        { }

        public AppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        { }

        public DbSet<PastModel> PastCar { get; set; }
        public DbSet<Configuration> Configuration { get; set; }
        public DbSet<MainPage> MainPage { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<ConfigTransmissionType> TransmissionType { get; set; }
        public DbSet<ConfigColor> Color { get; set; }
        public DbSet<ConfigEngine> Engine { get; set; }

        //Package manager console-ban kell futtatni
        //add-migration Init
        //script-migration
        //update-database

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PastModel>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<MainPage>().HasIndex(c => c.Id).IsUnique();
            modelBuilder.Entity<Sale>().HasIndex(c => c.Id).IsUnique();
            modelBuilder.Entity<User>().HasIndex(c => c.Id).IsUnique();
            modelBuilder.Entity<ConfigTransmissionType>().HasIndex(c => c.Id).IsUnique();
            modelBuilder.Entity<ConfigColor>().HasIndex(c => c.Id).IsUnique();
            modelBuilder.Entity<ConfigEngine>().HasIndex(c => c.Id).IsUnique();



            var configEngines = LoadConfigEnginesFromJson();

            foreach (var engine in configEngines)
            {
                if (engine.Id == 0)
                {
                    engine.Id = GetUniqueNegativeId();
                }
            }


            modelBuilder.Entity<ConfigEngine>().HasData(configEngines);

        }

        private List<ConfigEngine> LoadConfigEnginesFromJson()
        {
            // JSON fájl beolvasása
            var json = File.ReadAllText("ConfigEngine.json");
            return JsonConvert.DeserializeObject<List<ConfigEngine>>(json);
        }

        private int GetUniqueNegativeId()
        {
            // Generate unique negative Ids (this is a simple example, you might want a more robust solution)
            return -Math.Abs(Guid.NewGuid().GetHashCode());
        }
    }
}
