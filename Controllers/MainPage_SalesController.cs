using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainPage_SalesController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        public MainPage_SalesController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/<MainPageController>
        [HttpGet("mainpage")]
        public IActionResult GetMainPage()
        {
            var mainPage = _dbContext.MainPage.ToList();
            return Ok(mainPage);
        }
        // GET: api/<MainPage_SalesController>
        [HttpGet("sales")]
        public IActionResult Get()
        {
            var sales = _dbContext.Sale.ToList();
            return Ok(sales);
        }

        // GET api/<MainPage_SalesController>/5
        [HttpGet("sales/{id}")]
        public IActionResult GetSaleById(int id)
        {
            var sale = _dbContext.Sale.Find(id);

            if (sale == null)
            {
                return NotFound();
            }

            return Ok(sale);
        }

        // POST api/<MainPage_SalesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MainPage_SalesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MainPage_SalesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
