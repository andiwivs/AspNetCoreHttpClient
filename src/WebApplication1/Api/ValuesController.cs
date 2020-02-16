using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Api
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private static int GetCount = 0;


        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
            // simulate transient errors - only allow every 9th request to succeed
            GetCount++;

            if (GetCount % 9 != 0)
                return Problem(detail: "This is a simulated error", statusCode: 500);

            return Ok(new [] { "value1", "value2" });
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
