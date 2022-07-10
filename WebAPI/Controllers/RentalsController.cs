using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entity.Concreate;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class RentalsController : Controller
    {
        IRentalService _rentalService;
        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }
        // GET: api/values
        [HttpGet("Get All")]
        public IActionResult GetAll()
        {
            var result = _rentalService.GetAll();
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        // GET api/values/5
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _rentalService.GetAll();
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        // POST api/values
        [HttpPost("Add Rental")]
        public IActionResult Post(Rental rental)
        {
            var result = _rentalService.Add(rental);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        // PUT api/values/5
        [HttpPut("Update Rental")]
        public IActionResult Put(Rental rental)
        {
            var result = _rentalService.Update(rental);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        // DELETE api/values/5
        [HttpDelete("Delete Rental")]
        public IActionResult Delete(Rental rental)
        {
            var result = _rentalService.Delete(rental);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }
    }
}

