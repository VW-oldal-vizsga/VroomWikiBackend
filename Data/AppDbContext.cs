using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Models;
using Newtonsoft.Json;

namespace VroomWiki.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        { }

        public AppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        { }

        public DbSet<PastModel> PastModel { get; set; }
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
            modelBuilder.Entity<Configuration>().HasIndex(c => c.Id).IsUnique();


           
            var configEngines = LoadConfigEnginesFromJson();
            var configColor = LoadConfigColorFromJson();
            var configTransType = LoadConfigTransTypeFromJson();
            var mainPage = LoadMainPageFromJson();
            var pastModel = LoadPastModelsFromJson();
            var sales = LoadSalesFromJson();
            var users = LoadUsersFromJson();
            var configurations = LoadConfigurationsFromJson();


            foreach (var engine in configEngines)
            {
                if (engine.Id == 0)
                {
                    engine.Id = GetUniqueId();
                }
            }
            foreach (var color in configColor)
            {
                if (color.Id == 0)
                {
                    color.Id = GetUniqueId();
                }
            }
            foreach (var transType in configTransType)
            {
                if (transType.Id == 0)
                {
                    transType.Id = GetUniqueId();
                }
            }
            foreach (var mainP in mainPage)
            {
                if (mainP.Id == 0)
                {
                    mainP.Id = GetUniqueId();
                }
            }
            foreach (var pastM in pastModel)
            {
                if (pastM.Id == 0)
                {
                    pastM.Id = GetUniqueId();
                }
            }
            foreach (var sale in sales)
            {
                if (sale.Id == 0)
                {
                    sale.Id = GetUniqueId();
                }
            }
            foreach (var user in users)
            {
                if (user.Id == 0)
                {
                    user.Id = GetUniqueId();
                }
            }
            foreach (var config in configurations)
            {
                if (config.Id == 0)
                {
                    config.Id = GetUniqueId();
                }
            }

            modelBuilder.Entity<ConfigEngine>().HasData(configEngines);
            modelBuilder.Entity<ConfigColor>().HasData(configColor);
            modelBuilder.Entity<ConfigTransmissionType>().HasData(configTransType);
            modelBuilder.Entity<MainPage>().HasData(mainPage);
            modelBuilder.Entity<PastModel>().HasData(pastModel);
            modelBuilder.Entity<Sale>().HasData(sales);
            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<Configuration>().HasData(configurations);

        }

        
        private List<ConfigEngine> LoadConfigEnginesFromJson()
        {
            // JSON fájl beolvasása
            var json = File.ReadAllText("ConfigEngine.json");
            return JsonConvert.DeserializeObject<List<ConfigEngine>>(json);
        }
        private List<ConfigColor> LoadConfigColorFromJson()
        {
            // JSON fájl beolvasása
            var json = File.ReadAllText("ConfigColor.json");
            return JsonConvert.DeserializeObject<List<ConfigColor>>(json);
        }
        private List<ConfigTransmissionType> LoadConfigTransTypeFromJson()
        {
            // JSON fájl beolvasása
            var json = File.ReadAllText("ConfigTransmissionTypes.json");
            return JsonConvert.DeserializeObject<List<ConfigTransmissionType>>(json);
        }
        private List<MainPage> LoadMainPageFromJson()
        {
            // JSON fájl beolvasása
            var json = File.ReadAllText("MainPage.json");
            return JsonConvert.DeserializeObject<List<MainPage>>(json);
        }
        private List<PastModel> LoadPastModelsFromJson()
        {
            // JSON fájl beolvasása
            var json = File.ReadAllText("PastModels.json");
            return JsonConvert.DeserializeObject<List<PastModel>>(json);
        }
        private List<Sale> LoadSalesFromJson()
        {
            // JSON fájl beolvasása
            var json = File.ReadAllText("Sales.json");
            return JsonConvert.DeserializeObject<List<Sale>>(json);
        }
        private List<User> LoadUsersFromJson()
        {
            // JSON fájl beolvasása
            var json = File.ReadAllText("Users.json");
            return JsonConvert.DeserializeObject<List<User>>(json);
        }
        private List<Configuration> LoadConfigurationsFromJson()
        {
            // JSON fájl beolvasása
            var json = File.ReadAllText("Configurations.json");
            return JsonConvert.DeserializeObject<List<Configuration>>(json);
        }



        private static int _currentId = 1; // Kezdőérték 1
        private const int MaxId = 10;    // Maximális érték (itt például 1000)

        private int GetUniqueId()
        {
            if (_currentId > MaxId)
            {
                // Ha elérjük a maximális értéket, kezelhetjük ezt valamilyen módon
                // Például, visszaállíthatjuk 1-re vagy más logikát alkalmazhatunk
                _currentId = 1; // Visszaállítjuk 1-re, ha elérjük a maximális ID-t
            }

            return _currentId++;
        }
    }
}
