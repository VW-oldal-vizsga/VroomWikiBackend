﻿using VroomWiki.Controllers;
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
                    p.Price,
                    p.ImageUrl
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
                    p.Price,
                    p.ImageUrl
                }));
            });
        }

        
        [HttpGet("image/{id}")]
        public IActionResult GetImage(int id)
        {
            var imageUrl = configuratorRepository.GetImageConfig(id);

            if (string.IsNullOrEmpty(imageUrl))
            {
                return NotFound();
            }

            return Ok(imageUrl);
        }

        // POPULAR CONFIGS

        [HttpGet("popularconfigs")]
        public IActionResult GetPopularConfigurations()
        {
            return this.Run(() =>
            {
                return Ok(configuratorRepository.GetAllPopularConfigs().Select(p => new
                {
                    p.Id,
                    p.Color_Id,
                    p.Engine_Id,
                    p.TransmissionType_Id,
                    p.ConfigName,
                    p.Price,
                    p.ImageBase64
                }));
            });
        }

        [HttpGet("popularconfigs/{id}")]
        public IActionResult GetOnePopularConfig(int id)
        {
            return this.Run(() =>
            {
                return Ok(configuratorRepository.GetOnePopularConfig(id).Select(p => new
                {
                    p.Id,
                    p.Color_Id,
                    p.Engine_Id,
                    p.TransmissionType_Id,
                    p.ConfigName,
                    p.Price,
                    p.ImageBase64
                }));
            });
        }

        [HttpGet("popularconfigs/image/{id}")]
        public IActionResult GetImagePopularConfig(int id)
        {
            return this.Run(() =>
            {
                return File(configuratorRepository.GetImagePopularConfig(id), "image/jpeg");
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
                    p.Price,
                    p.ImageBase64,
                    p.ColorCode
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
                    p.Price,
                    p.ImageBase64,
                    p.ColorCode
                }));
            });
        }

        [HttpGet("color/image/{id}")]
        public IActionResult GetImageColor(int id)
        {
            return this.Run(() =>
            {
                return File(configuratorRepository.GetImageColor(id), "image/jpeg");
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
        public IActionResult GetOneEngine(int id)
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
        public IActionResult GetOneTransmission(int id)
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
        [Authorize(Roles = "Admin,User")]
        public IActionResult AddConfiguration(dynamic newConfig)
        {
            return this.Run(() =>
            {
                var config = JsonConvert.DeserializeObject<Configuration>(newConfig.ToString());
                return Ok(configuratorRepository.AddConfiguration(config));
            });
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin,User")]
        public IActionResult UpdateConfiguration(int id, dynamic configToModify)
        {
            return this.Run(() =>
            {
                return Ok(configuratorRepository.UpdateConfiguration(id, configToModify));
            });
        }

        [HttpDelete("{id}")]
       [Authorize(Roles = "Admin,User")]
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
