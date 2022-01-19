using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotosController : ControllerBase
    {
        // GET: api/Photos
        [HttpGet]
        public IActionResult Get()
        {
            Byte[] b = System.IO.File.ReadAllBytes(@"C:\Users\Yelyzaveta\Desktop\ASP.NET_AJAX\WebApplication3\WebApplication3\images\background.jpg");   // You can use your own method over here.         
            return File(b, "background.jpg");
        }

        // GET: api/Photos/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Photos
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Photos/5
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
