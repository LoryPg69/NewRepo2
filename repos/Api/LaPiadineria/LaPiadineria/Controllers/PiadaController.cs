using LaPiadineria.Models;
using LaPiadineriaApi;
using LaPiadineriaApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace LaPiadineria.Controllers
{
    [ApiController]
    [Route("api/lapiadineria")]
    public class PiadaController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<DrinkModel>> GetPiadas()
        {

            return Ok(DrinkRepository.Current.Piada);

        }

        [HttpGet("{id}")]
        public ActionResult<DrinkModel> GetPiada(int id)
        {

            var cityToReturn = DrinkRepository.Current.Piada.FirstOrDefault(c => c.Id == id);

            if (cityToReturn == null)
            {
                return NotFound();
            }

            return Ok(cityToReturn);
        }
    }
}
