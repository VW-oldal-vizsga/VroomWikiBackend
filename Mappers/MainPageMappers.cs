using Models;
using VroomWiki.DTOs.MainPage;

namespace VroomWiki.Mappers
{
    public static class MainPageMappers
    {
        public static MainPageDTO ToMainPageDTO(this MainPage mainPage)
        {
            return new MainPageDTO
            {
                Id = mainPage.Id,
                Description = mainPage.Description,
                Founded = mainPage.Founded,
                Headquarters = mainPage.Headquarters,
                Factories = mainPage.Factories,
                Chairman = mainPage.Chairman,
                Owner = mainPage.Owner,
                Products = mainPage.Products,
                Employees = mainPage.Employees,
                History = mainPage.History,
                Profit = mainPage.Profit
            };
        }
    }
}
