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
    public class ConfiguratorController : ControllerBase
    {
        private readonly ConfiguratorRepository configuratorRepository;

        public ConfiguratorController(ConfiguratorRepository configuratorRepository)
        {
            this.configuratorRepository = configuratorRepository;
        }

        [HttpGet]
        public IActionResult GetConfigurations()
        {
            return this.Run(() =>
            {
                return Ok(configuratorRepository.GetAllConfigs().Select(p => new
                {
                    p.Id,
                    p.Color_Id,
                    p.Engine_Id,
                    p.TransmissionType_Id,
                    p.ConfigName,
                    p.User_Id,
                    p.Price
                }));
            });
        }

        [HttpGet("{id}")]
        public IActionResult GetOneConfiguration(int id)
        {
            return this.Run(() =>
            {
                return Ok(configuratorRepository.GetOneConfiguration(id).Select(p => new
                {
                    p.Id,
                    p.Color_Id,
                    p.Engine_Id,
                    p.TransmissionType_Id,
                    p.ConfigName,
                    p.User_Id,
                    p.Price
                }));
            });
        }


        // COLORS

        // GET: api/<ConfiguratorController>
        [HttpGet("colors")]
        public IActionResult GetAllColors()
        {
            return this.Run(() =>
            {
                return Ok(configuratorRepository.GetAllColor().Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.Price
                }));
            });
        }

        // GET api/<ConfiguratorController>/5
        [HttpGet("colors/{id}")]
        public IActionResult GetOneColor(int id)
        {
            return this.Run(() =>
            {
                return Ok(configuratorRepository.GetOneColor(id).Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.Price
                }));
            });
        }

        // ENGINES

        [HttpGet("engines")]
        public IActionResult GetAllEngines()
        {
            return this.Run(() =>
            {
                return Ok(configuratorRepository.GetAllEngines().Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.Horsepower,
                    p.FuelConsumption,
                    p.Co2Emission,
                    p.FuelType,
                    p.Price
                }));
            });
        }

        // GET api/<ConfiguratorController>/5
        [HttpGet("engines/{id}")]
        public IActionResult GetOneEngines(int id)
        {
            return this.Run(() =>
            {
                return Ok(configuratorRepository.GetOneEngine(id).Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.Horsepower,
                    p.FuelConsumption,
                    p.Co2Emission,
                    p.FuelType,
                    p.Price
                }));
            });
        }

        // TRANSMISSION_TYPES

        [HttpGet("transmissions")]
        public IActionResult GetAllTransmissions()
        {
            return this.Run(() =>
            {
                return Ok(configuratorRepository.GetAllTransmissions().Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.WheelDrive,
                    p.Price
                }));
            });
        }

        [HttpGet("transmission/{id}")]
        public IActionResult GetOneTransmissions(int id)
        {
            return this.Run(() =>
            {
                return Ok(configuratorRepository.GetOneTransmission(id).Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.WheelDrive,
                    p.Price
                }));
            });
        }

        [HttpPost]
        //[Authorize(Roles = "admin")]
        public IActionResult AddConfiguration(dynamic newConfig)
        {
            return this.Run(() =>
            {
                var config = JsonConvert.DeserializeObject<Configuration>(newConfig.ToString());
                return Ok(configuratorRepository.AddConfiguration(config));
            });
        }

        [HttpPut("{id}")]
        //[Authorize(Roles = "admin")]
        public IActionResult UpdateConfiguration(int id, dynamic configToModify)
        {
            return this.Run(() =>
            {
                return Ok(configuratorRepository.UpdateConfiguration(id, configToModify));
            });
        }

        [HttpDelete("{id}")]
       //[Authorize(Roles = "admin")]
        public IActionResult DeleteConfiguration(int id)
        {
            return this.Run(() =>
            {
                configuratorRepository.DeleteConfiguration(id);
                return Ok();
            });
        }
    }
}
