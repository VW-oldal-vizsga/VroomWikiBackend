using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfiguratorController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public ConfiguratorController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: api/<ConfiguratorController>
        [HttpGet]
        public IActionResult GetColors()
        {
            var colors = _dbContext.Color.ToList();
            return Ok(colors);
        }

        // GET api/<ConfiguratorController>/5
        [HttpGet("{id}")]
        public IActionResult GetColorId([FromRoute])
        {
            return "value";
        }

        // POST api/<ConfiguratorController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ConfiguratorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ConfiguratorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
