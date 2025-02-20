using Microsoft.AspNetCore.Mvc;
using VroomWiki.Data;
using VroomWiki.Mappers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VroomWiki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PastModelsController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        public PastModelsController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: api/<PastModelsController>
        [HttpGet]
        public IActionResult GetPastModels()
        {
            var pastModels = _dbContext.PastModel.ToList()
                .Select(p =>p.ToPastModelsDTO());
            return Ok(pastModels);
        }

        // GET api/<PastModelsController>/5
        [HttpGet("{id}")]
        public IActionResult GetPastModelById(int id)
        {
            var pastModel= _dbContext.PastModel.Find(id);

            if (pastModel== null)
            {
                return NotFound();
            }

            return Ok(pastModel.ToPastModelsDTO());
        }

        // POST api/<PastModelsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PastModelsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PastModelsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
