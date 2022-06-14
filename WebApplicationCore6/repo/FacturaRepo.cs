using WebApplication1.gestionvta;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace WebApplicationCore6.repo
{
    public class FacturaVtaRepo
    {
        public static List<Facturasvtas> Listar()
        {
            var resultado = new List<Facturasvtas>();

            using(var ctx=new gestionvtasContext())
            {
                resultado=ctx.Facturasvtas
                    .Include( f => f.Detalledctos)
                        .ThenInclude( dd => dd.IdproductosNavigation)
                    .ToList();
            }
            return resultado;
        }
        public static int Insertar(Facturasvtas f)
        {
            using (var ctx = new gestionvtasContext())
            {
                ctx.Facturasvtas.Add(f);
                ctx.SaveChanges();
            }
            return f.Idfactvta;
        }
    }
}
