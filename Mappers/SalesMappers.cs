using Models;
using VroomWiki.DTOs.MainPage;

namespace VroomWiki.Mappers
{
    public static class SalesMappers
    {
        public static SalesDTO ToSalesDTO(this Sale sale)
        {
            return new SalesDTO
            {
                Id = sale.Id,
                Year = sale.Year,
                TotalSale = sale.TotalSale,
                TotalIncome = sale.TotalIncome
            };
        }
    }
}
