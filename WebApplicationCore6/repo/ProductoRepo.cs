using WebApplication1.gestionvta;

namespace WebApplicationCore6.repo
{
    public class ProductoRepo
    {
        public static List<Productos> Listar()
        {
            var resultado = new List<Productos>();

            using (var ctx = new gestionvtasContext())
            {
                resultado = ctx.Productos.ToList();
            }
            return resultado;
        }
    }
}
