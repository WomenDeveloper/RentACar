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
    public class BrandsController : Controller
    {
        IBrandService _brandService;
        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }
        // GET: api/values
        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _brandService.GetAll();
            if (result.Success) return Ok(result);
            return  BadRequest(result);
        }

        // GET api/values/5
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _brandService.GetById(id);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post(Brand brand)
        {
            var result = _brandService.Add(brand);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(Brand brand)
        {
            var result = _brandService.Update(brand);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Brand brand)
        {
            var result = _brandService.Delete(brand);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }
    }
}

