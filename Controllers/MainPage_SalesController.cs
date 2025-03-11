using VroomWiki.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models;
using Newtonsoft.Json;
using VroomWiki.Data;

using VroomWiki.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VroomWiki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainPage_SalesController : ControllerBase
    {
        private readonly MainPage_SalesRepository mainPage_SalesRepository;

        public MainPage_SalesController(MainPage_SalesRepository mainPage_SalesRepository)
        {
            this.mainPage_SalesRepository = mainPage_SalesRepository;
        }

        // GET: api/<MainPageController>
        [HttpGet("mainpage")]
        public IActionResult GetAllMp()
        {
            return this.Run(() =>
            {
                return Ok(mainPage_SalesRepository.GetAllMp().Select(p => new
                {
                    p.Id,
                    p.Description,
                    p.Owner,
                    p.Employees,
                    p.Factories,
                    p.Chairman,
                    p.Founded,
                    p.Headquarters,
                    p.Products,
                    p.Profit,
                    p.ImageBase64
                }));
            });
        }

        [HttpGet("mainpage/history")]
        public IActionResult GetAllMpHistory()
        {
            return this.Run(() =>
            {
                return Ok(mainPage_SalesRepository.GetAllMpHistory().Select(p => new
                {
                    p.Id,
                    p.Title,
                    p.History
                    
                }));
            });
        }


        [HttpGet("mainpage/history/{id}")]
        public IActionResult GetOneMpHistory(int id)
        {
            return this.Run(() =>
            {
                return Ok(mainPage_SalesRepository.GetOneMpHistory(id).Select(p => new
                {
                    p.Id,
                    p.Title,
                    p.History

                }));
            });
        }

        // GET: api/<MainPage_SalesController>
        [HttpGet("sales")]
        public IActionResult GetAllSale()
        {
            return this.Run(() =>
            {
                return Ok(mainPage_SalesRepository.GetAllSale().Select(p => new
                {
                    p.Id,
                    p.Year,
                    p.TotalSale,
                    p.TotalIncome,
                    
                }));
            });
        }

        // GET api/<MainPage_SalesController>/5
        [HttpGet("sales/{id}")]
        public IActionResult GetSaleById(int id)
        {
            return this.Run(() =>
            {
                return Ok(mainPage_SalesRepository.GetOneSales(id).Select(p => new
                {
                    p.Id,
                    p.TotalSale,
                    p.TotalIncome,
                    p.Year,

                }));
            });
        }

        //POST api/<PastModelsController>
        [HttpPost("sales")]
        //[Authorize(Roles = "admin")]
        public IActionResult AddSale(dynamic newSale)
        {
            return this.Run(() =>
            {
                var sale = JsonConvert.DeserializeObject<Sale>(newSale.ToString());
                return Ok(mainPage_SalesRepository.AddSale(sale));
            });
        }

        [HttpDelete("sales/{id}")]
        //[Authorize(Roles = "admin")]
        public IActionResult DeleteSale(int id)
        {
            return this.Run(() =>
            {
                mainPage_SalesRepository.DeleteSale(id);
                return Ok();
            });
        }
    }
}
