using Microsoft.AspNetCore.Mvc;
using VroomWiki.Data;
using VroomWiki.Mappers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VroomWiki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfiguratorController : ControllerBase
    {
        private const string id = "{id}";
        private readonly AppDbContext _dbContext;

        public ConfiguratorController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // COLORS

        // GET: api/<ConfiguratorController>
        [HttpGet("colors")]
        public IActionResult GetColors()
        {
            var colors = _dbContext.Color.ToList()
                .Select(c=> c.ToConfigColorDTO());
            return Ok(colors);
        }

        // GET api/<ConfiguratorController>/5
        [HttpGet("colors/{id}")]
        public IActionResult GetColorById([FromRoute] int id)
        {
            var color=_dbContext.Color.Find(id);

            if (color==null)
            {
                return NotFound();   
            }

            return Ok(color.ToConfigColorDTO());
        }

        // ENGINES

        [HttpGet("engines")]
        public IActionResult GetEngines()
        {
            var engines = _dbContext.Engine.ToList();
            return Ok(engines);
        }

        // GET api/<ConfiguratorController>/5
        [HttpGet("engines/{id}")]
        public IActionResult GetEngineById([FromRoute] int id)
        {
            var engine = _dbContext.Engine.Find(id);

            if (engine == null)
            {
                return NotFound();
            }

            return Ok(engine);
        }

        // TRANSMISSION_TYPES

        [HttpGet("transmissions")]
        public IActionResult GetTransmissionTypes()
        {
            var transTypes = _dbContext.TransmissionType.ToList();
            return Ok(transTypes);
        }

        [HttpGet("transmission/{id}")]
        public IActionResult GetTransmissionTypeById([FromRoute] int id)
        {
            var transType = _dbContext.TransmissionType.Find(id);

            if (transType == null)
            {
                return NotFound();
            }

            return Ok(transType);
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
