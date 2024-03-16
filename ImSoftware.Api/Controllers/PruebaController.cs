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
        public IEnumerable<PruebaDTO> GetPruebas()
        {
            return PruebaStore.PruebaList;
        }

        [HttpGet("id:int")]
        public PruebaDTO GetPrueba(int Id)
        {
            return PruebaStore.PruebaList.FirstOrDefault(p => p.Id == Id);
        }
    }
}
