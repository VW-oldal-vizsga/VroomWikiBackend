﻿using Microsoft.AspNetCore.Mvc;
using VroomWiki.Data;
using VroomWiki.Mappers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VroomWiki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        
        private readonly AppDbContext _dbContext;
        public AuthController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/<AuthController>


        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _dbContext.User.ToList()
                .Select(u => u.ToUsersDTO());
            return Ok(users);
        }

        // GET api/<AuthController>/5
        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            var user = _dbContext.User.Find(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user.ToUsersDTO());
        }

        // POST api/<AuthController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AuthController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AuthController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
