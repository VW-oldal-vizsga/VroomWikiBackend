using VroomWiki.Extensions;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Models;
using Newtonsoft.Json;
using VroomWiki.Models;

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
        public DbSet<MainPageHistory> MainPageHistory { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<ConfigTransmissionType> TransmissionTypes { get; set; }
        public DbSet<ConfigColor> Color { get; set; }
        public DbSet<ConfigEngine> Engine { get; set; }
        public DbSet<SessionModel> Sessions{ get; set; }
        public DbSet<UserRoleModel> UserRoles{ get; set; }

        //Package manager console-ban kell futtatni
        //add-migration Init
        //script-migration
        //update-database

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PastModel>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<MainPage>().HasIndex(c => c.Id).IsUnique();
            modelBuilder.Entity<MainPageHistory>().HasIndex(c => c.Id).IsUnique();
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
            var mainPageHistory = LoadMainPageHistoryFromJson();
            var pastModel = LoadPastModelsFromJson();
            var sales = LoadSalesFromJson();
            var users = LoadUsersFromJson();
            var configurations = LoadConfigurationsFromJson();

            modelBuilder.Entity<ConfigEngine>().HasData(configEngines);
            modelBuilder.Entity<ConfigColor>().HasData(configColor);
            modelBuilder.Entity<ConfigTransmissionType>().HasData(configTransType);
            modelBuilder.Entity<MainPage>().HasData(mainPage);
            modelBuilder.Entity<MainPageHistory>().HasData(mainPageHistory);
            modelBuilder.Entity<PastModel>().HasData(pastModel);
            modelBuilder.Entity<Sale>().HasData(sales);
            modelBuilder.Entity<User>().HasData(
                users.Select(u=>new
                {
                    Id= u.Id,
                    Email=u.Email,
                    Username = u.Username,
                    PasswordHash= u.Password!.HashPassword(),
                    CreatedAt = DateTime.Now,
                })
                );
            modelBuilder.Entity<RoleModel>().HasData(
                new RoleModel() { Id = 1, Name = "Admin" },
                new RoleModel() { Id = 2, Name = "User" }
                );

            modelBuilder.Entity<UserRoleModel>().HasData(
                    new {Id=1, UserId=1,RoleId=1},
                    new {Id=2, UserId=2,RoleId=2},
                    new {Id=3, UserId=3,RoleId=2}
                );

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
        private List<MainPageHistory> LoadMainPageHistoryFromJson()
        {
            // JSON fájl beolvasása
            var json = File.ReadAllText("MainPageHistory.json");
            return JsonConvert.DeserializeObject<List<MainPageHistory>>(json);
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

    }
}
