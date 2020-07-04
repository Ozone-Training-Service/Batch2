using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentRegister.Models;
namespace WebApis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentApiController : ControllerBase
    {
        // GET: api/StudentApi
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("GetData")]
        public IActionResult  GetData()
        {

            Register obj = new Register();
            obj.Name = "Vishnu";
            obj.Email = "Vishnu@gmail.com";
            return Ok(obj);
        }

        // GET: api/StudentApi/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/StudentApi
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/StudentApi/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
