using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _threeapis.Controllers
{
    [Route("api/fibonacci")]
    [ApiController]
    public class FibonacciController : ControllerBase
    {

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Convert.ToString(Fibonacci.get(10)));
        }
        // GET api/values/5
        [HttpGet("number")]
        public IActionResult Get(int number)
        {
            return Ok(Convert.ToString(Fibonacci.get(number)));
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
