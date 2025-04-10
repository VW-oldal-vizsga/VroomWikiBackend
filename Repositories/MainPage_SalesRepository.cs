﻿using Models;
using Newtonsoft.Json;
using VroomWiki.Data;
using VroomWiki.Models;


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
        public IEnumerable<MainPageHistory> GetAllMpHistory()
        {
            return context.Set<MainPageHistory>();
        }

        public IEnumerable<MainPageHistory> GetOneMpHistory(int id)
        {
            return context.Set<MainPageHistory>().Where(p => p.Id == id);
        }


        public IEnumerable<Sale> GetAllSale()
        {
            return context.Set<Sale>();
        }

        public IEnumerable<Sale> GetOneSales(int id)
        {
            return context.Set<Sale>().Where(p => p.Id == id);
        }

       

        public Sale AddSale(dynamic sale)
        {
            var entity = context.Set<Sale>().Add(sale);
            context.SaveChanges();
            return entity.Entity;
        }


        public void DeleteSale(int saleId)
        {
            var sale = context.Set<Sale>().SingleOrDefault(p => p.Id == saleId);
            if (sale == null)
                throw new Exception("Model not found");

            context.Set<Sale>().Remove(sale);
            context.SaveChanges();
        }

        public byte[] GetImage(int id)
        {
            var mainPage = context.Set<MainPage>().SingleOrDefault(p => p.Id == id);
            if (mainPage == null)
                return null!;
            return Convert.FromBase64String(mainPage.ImageBase64);
        }

        public byte[] GetImageChairman(int id)
        {
            var mainPage = context.Set<MainPage>().SingleOrDefault(p => p.Id == id);
            if (mainPage == null)
                return null!;
            return Convert.FromBase64String(mainPage.ImageBase64Chairman);
        }

        public byte[] GetImageBratislava(int id)
        {
            var mainPage = context.Set<MainPage>().SingleOrDefault(p => p.Id == id);
            if (mainPage == null)
                return null!;
            return Convert.FromBase64String(mainPage.ImageBase64Bratislava);
        }

        public byte[] GetImageWolfsburg(int id)
        {
            var mainPage = context.Set<MainPage>().SingleOrDefault(p => p.Id == id);
            if (mainPage == null)
                return null!;
            return Convert.FromBase64String(mainPage.ImageBase64Wolfsburg);
        }

        public byte[] GetImageDresden(int id)
        {
            var mainPage = context.Set<MainPage>().SingleOrDefault(p => p.Id == id);
            if (mainPage == null)
                return null!;
            return Convert.FromBase64String(mainPage.ImageBase64Dresden);
        }

    }
}
