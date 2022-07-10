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
    public class CarsController : Controller
    {
        ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
        }
        // GET: api/values
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            if (result.Success) return Ok(result);
            return  BadRequest(result.Message);
        }

        // GET api/values/5
        [HttpGet("GetById")]
        public IActionResult Get(int id)
        {
            var result = _carService.GetById(id);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        // POST api/values
        [HttpPost("Add Car")]
        public IActionResult Post(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success) return Ok(result);
            return BadRequest(result);

        }

        // PUT api/values/5
        [HttpPut("Update Car")]
        public IActionResult Put(Car car)
        {
            var result = _carService.Update(car);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        // DELETE api/values/5
        [HttpDelete("Delete Car")]
        public IActionResult Delete(Car car)
        {
            var result = _carService.Delete(car);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }
    }
}

