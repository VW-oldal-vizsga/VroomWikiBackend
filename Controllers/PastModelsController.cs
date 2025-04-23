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
    public class PastModelsController : ControllerBase
    {
        private readonly PastModelsRepository pastModelsRepository;

        public PastModelsController(PastModelsRepository pastModelsRepository)
        {
            this.pastModelsRepository = pastModelsRepository;
        }
        // GET: api/<PastModelsController>
        [HttpGet]
        public IActionResult GetAllModels()
        {
            return this.Run(() =>
            {
                return Ok(pastModelsRepository.GetAll().Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.DescriptionHU,
                    p.DescriptionEN,
                    p.DescriptionDE,
                    p.ReleaseDate,
                    p.DesignHU,
                    p.DesignEN,
                    p.DesignDE,
                    p.Designer,
                    p.Production,
                    p.Assembly,
                    p.Engine,
                    p.Horsepower,
                    p.ImageBase64
                }));
            });
        }

        // GET api/<PastModelsController>/5
        [HttpGet("{id}")]
        public IActionResult GetOneModel(int id)
        {
            return this.Run(() =>
            {
                return Ok(pastModelsRepository.GetOneModel(id).Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.DescriptionHU,
                    p.DescriptionEN,
                    p.DescriptionDE,
                    p.ReleaseDate,
                    p.DesignHU,
                    p.DesignEN,
                    p.DesignDE,
                    p.Designer,
                    p.Production,
                    p.Assembly,
                    p.Engine,
                    p.Horsepower,
                    p.ImageBase64,
                }));
            });
        }

        [HttpGet("image/{id}")]
        public IActionResult GetImage(int id)
        {
            return this.Run(() =>
            {
                return File(pastModelsRepository.GetImage(id), "image/jpeg");
            });
        }

        //POST api/<PastModelsController>
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult AddPastModel(dynamic newPastModel)
        {
            return this.Run(() =>
            {
                var pastModel = JsonConvert.DeserializeObject<PastModel>(newPastModel.ToString());
                return Ok(pastModelsRepository.AddPastModel(pastModel));
            });
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult UpdatePastModel(int id, dynamic pastModelToModify)
        {
            return this.Run(() =>
            {
                return Ok(pastModelsRepository.UpdatePastModel(id, pastModelToModify));
            });
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult DeletePastModel(int id)
        {
            return this.Run(() =>
            {
                pastModelsRepository.DeletePastModel(id);
                return Ok();
            });
        }
    }
}
