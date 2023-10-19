using LaPiadineriaApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace LaPiadineriaApi.Controllers
{
    [Route("api/lapiadineria/{piadaId}/item")]
    [ApiController]

    public class ItemController: ControllerBase
    {
        
           

            public ActionResult<IEnumerable<ItemController>> GetPointsOfInternet(int piadaId)
            {

                var piada = DrinkRepository.Current.Piada.FirstOrDefault(c => c.Id == piadaId);

                if (piada == null)
                {
                    return NotFound();

                }
                return Ok(piada.Items);
            }

            [HttpGet("{itemId:int}")]

            public ActionResult<IEnumerable<ItemController>> GetItem(int piadaId, int itemId)
            {
                var piada = DrinkRepository.Current.Piada.FirstOrDefault(p => p.Id == piadaId);
                if (piada == null)
                {
                    return NotFound();

                }
                var item = piada.Items.FirstOrDefault(i => i.Id == itemId);

                if (item == null)
                {
                    return NotFound();

                }
                return Ok(item);
            }

        }
    }

