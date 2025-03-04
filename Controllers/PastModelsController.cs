using Backend_Webshop.Controllers;
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
        public IActionResult GetProducts()
        {
            return this.Run(() =>
            {
                return Ok(pastModelsRepository.GetAll().Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.Description,
                    p.ReleaseDate,
                    p.Engine,
                    p.Horsepower
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
                    p.Description,
                    p.ReleaseDate,
                    p.Engine,
                    p.Horsepower
                }));
            });
        }

        //POST api/<PastModelsController>
        [HttpPost]
        //[Authorize(Roles = "admin")]
        public IActionResult AddPastModel(dynamic newPastModel)
        {
            return this.Run(() =>
            {
                var pastModel = JsonConvert.DeserializeObject<PastModel>(newPastModel.ToString());
                return Ok(pastModelsRepository.AddPastModel(pastModel));
            });
        }

        [HttpPut("{id}")]
        //[Authorize(Roles = "admin")]
        public IActionResult UpdatePastModel(int id, dynamic pastModelToModify)
        {
            return this.Run(() =>
            {
                return Ok(pastModelsRepository.UpdatePastModel(id, pastModelToModify));
            });
        }

        [HttpDelete("{id}")]
        //[Authorize(Roles = "admin")]
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
