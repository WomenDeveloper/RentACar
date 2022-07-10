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
    public class CustomersController : Controller
    {
        ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        // GET: api/values
        [HttpGet("Get All")]
        public IActionResult GetAll()
        {
            var result = _customerService.GetAll();
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        // GET api/values/5
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _customerService.GetAll();
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        // POST api/values
        [HttpPost("Add Customer")]
        public IActionResult Post(Customer customer)
        {
            var result = _customerService.Add(customer);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        // PUT api/values/5
        [HttpPut("Update Customer")]
        public IActionResult Put(Customer customer)
        {
            var result = _customerService.Update(customer);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        // DELETE api/values/5
        [HttpDelete("Delete Customer")]
        public IActionResult Delete(Customer customer)
        {
            var result = _customerService.Delete(customer);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }
    }
}

