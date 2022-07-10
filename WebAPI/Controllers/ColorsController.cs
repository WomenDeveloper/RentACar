using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concreate;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ColorsController : Controller
    {
        IColorService _colorService;
        public ColorsController(IColorService colorService)
        {
            _colorService = colorService;
        }
        // GET: api/values
        [HttpGet("Get All")]
        public IActionResult GetAll()
        {
            var result = _colorService.GetAll();
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        // GET api/values/5
        [HttpGet("GetById")]
        public IActionResult Get(int id)
        {
            var result = _colorService.GetById(id);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        // POST api/values
        [HttpPost("Add Color")]
        public IActionResult Post(Color color)
        {
            var result = _colorService.Add(color);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        // PUT api/values/5
        [HttpPut("Update Color")]
        public IActionResult Put(Color color)
        {
            var result = _colorService.Update(color);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        // DELETE api/values/5
        [HttpDelete("Delete Color")]
        public IActionResult Delete(Color color)
        {
            var result = _colorService.Delete(color);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }
    }
}

