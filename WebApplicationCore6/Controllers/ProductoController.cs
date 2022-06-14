using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.gestionvta;
using WebApplicationCore6.repo;

namespace WebApplicationCore6.Controllers
{

    [ApiController]
    public class ProductoController : ControllerBase
    {

        [Route("api/[controller]/listar")]
        public List<Productos> Listar()
        {
            return ProductoRepo.Listar();
        }

    }
}
