using ImSoftware.Api.Controllers.Modelos;
using ImSoftware.Api.Datos;
using ImSoftware.Api.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ImSoftware.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PruebaController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<PruebaDTO>> GetPruebas()
        {
            return  Ok(PruebaStore.PruebaList);
        }

        [HttpGet("id:int")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<PruebaDTO> GetPrueba(int Id)
        {
            if (Id==0)
            {
                return BadRequest();
            }

            var prueba = PruebaStore.PruebaList.FirstOrDefault(p => p.Id == Id);

            if (Id== null)
            {
                return NotFound();
            }

            return Ok(prueba);

        }
    }
}
