using Microsoft.AspNetCore.Mvc;
using PrimoController.DTO;
using System.Collections;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace PrimoController.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private string[] _values;
        public ValuesController()
        {
            _values = new string[] { "value1", "value2", "value3" };
        }

        [HttpGet]
        public IEnumerable Get()
        {
            return _values;

        }
        [HttpGet("{id}")]  //lo trovi nel URL
        public IActionResult Get(int id)
        {
            //object test = new
            //{
            //    Id = id
            //};
            if (id > _values.Length)
            {
                return BadRequest("id greater then avaible data");

            }
            Console.WriteLine(id);
            return Ok(new { values = _values[id-1] });
            
            //ShipperDto s = new ShipperDto()
            //{
            //    Phone = "333 333 3344",
            //    Email = "lollo@gmail.com"

            //};
            //return Ok(s);
        }
        [HttpPost]
        public IActionResult Post( [FromBody] ShipperDto shipper) //frombody è un attributo di shipper 
        {
            if (!ModelState.IsValid)  //validazione dei dati (cosa fondamentale per API) 
            {
                return BadRequest();
            }
            return CreatedAtAction("Get", new //
            {Shipper = shipper}, shipper);
        }
        
    }
}
