using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.gestionvta;
using WebApplicationCore6.repo;

namespace WebApplicationCore6.Controllers
{

    [ApiController]
    public class FacturaVtaController : ControllerBase
    {
        [Route("api/[controller]/listar")]
        public List<Facturasvtas> Listar()
        {
            return FacturaVtaRepo.Listar();
        }


        [Route("api/[controller]/insertar")]
        [HttpPost]
        public int Insertar([FromBody]Facturasvtas fv)
        {
            return FacturaVtaRepo.Insertar(fv);
        }

    }
}
