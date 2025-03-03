using Models;
using Newtonsoft.Json;
using VroomWiki.Data;

namespace VroomWiki.Repositories
{
    public class MainPage_SalesRepository
    {
        private readonly AppDbContext context;
        public MainPage_SalesRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<MainPage> GetAllMp()
        {
            return context.Set<MainPage>();
        }

        public IEnumerable<Sale> GetAllSale()
        {
            return context.Set<Sale>();
        }

        public IEnumerable<Sale> GetOneSales(int id)
        {
            return context.Set<Sale>().Where(p => p.Id == id);
        }

        //public byte[] GetImage(int id)
        //{
        //    var mainPage = context.Set<PastModel>().SingleOrDefault(p => p.Id == id);
        //    if (mainPage == null)
        //        return null!;
        //    return Convert.FromBase64String(mainPage.ImageBase64);
        //}

        public Sale AddSale(dynamic sale)
        {
            var entity = context.Set<Sale>().Add(sale);
            context.SaveChanges();
            return entity.Entity;
        }


        public void DeleteSale(int saleId)
        {
            var sale = context.Set<PastModel>().SingleOrDefault(p => p.Id == saleId);
            if (sale == null)
                throw new Exception("Model not found");

            context.Set<PastModel>().Remove(sale);
            context.SaveChanges();
        }
    }
}
