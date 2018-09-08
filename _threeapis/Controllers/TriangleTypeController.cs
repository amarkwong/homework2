using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _threeapis.Controllers
{
    [Route("api/triangletype")]
    [ApiController]
    public class TriangleTypeController : ControllerBase
    {

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Convert.ToString(TriangleType.get(1,1,1)));
        }
        // GET api/values/5
        [HttpGet("a/b/c")]
        public IActionResult Get(int a, int b, int c)
        {
            return Ok(Convert.ToString(TriangleType.get(a,b,c)));
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
