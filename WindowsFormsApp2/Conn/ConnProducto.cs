using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.gestionvta;

namespace WindowsFormsApp2.Conn
{
    public class ConnProducto
    {

        public static async Task<List<Productos>> ListarAsync()
        {
            var resultado = new List<Productos>();
            try
            {
                using (var client = new HttpClient())
                {
                    //client.DefaultRequestHeaders.Add("token", Configuracion.Token);
                    var conexion = await client.GetAsync(Configuracion.urlbase + "/Producto/listar");
                    var contenido = await conexion.Content.ReadAsStringAsync();

                    // Newtownsoft
                    resultado = JsonConvert.DeserializeObject<List<Productos>>(contenido);
                }
            }
            catch (Exception ex)
            {
                var usuariocarpeta = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                File.AppendAllText(usuariocarpeta + "\\errores.log", ex.Message + " "
                    + ex.InnerException.Message + " " + DateTime.Now.ToString() + "\n");

                resultado = null;
            }
            return resultado;
        }

    }

}
