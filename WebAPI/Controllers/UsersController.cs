using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Entities.Concreate;
using Entity.Concreate;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        // GET: api/values
        [HttpGet("Get All")]
        public IActionResult GetAll()
        {
            var result = _userService.GetAll();
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        // GET api/values/5
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _userService.GetAll();
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        // POST api/values
        [HttpPost("Add User")]
        public IActionResult Post(User user)
        {
            var result = _userService.Add(user);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        // PUT api/values/5
        [HttpPut("Update User")]
        public IActionResult Put(User user)
        {
            var result = _userService.Update(user);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        // DELETE api/values/5
        [HttpDelete("Delete User")]
        public IActionResult Delete(User user)
        {
            var result = _userService.Delete(user);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }
    }
}

