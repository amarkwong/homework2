using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _threeapis.Controllers
{
    [Route("api/reverswords")]
    [ApiController]
    public class ReversWordsController : ControllerBase
    {

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Convert.ToString(ReverseWords.get("")));
        }
        // GET api/values/5
        [HttpGet("String")]
        public IActionResult Get(string str)
        {
            return Ok(Convert.ToString(ReverseWords.get(str)));
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
