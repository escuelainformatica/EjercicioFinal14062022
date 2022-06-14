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
    public class ConnFacturaVta
    {

        public static async Task<List<Facturasvtas>> ListarAsync()
        {
            var resultado = new List<Facturasvtas>();
            try
            {
                using (var client = new HttpClient())
                {
                    //client.DefaultRequestHeaders.Add("token", Configuracion.Token);
                    var conexion = await client.GetAsync(Configuracion.urlbase + "/FacturaVta/listar");
                    var contenido = await conexion.Content.ReadAsStringAsync();

                    // Newtownsoft
                    resultado = JsonConvert.DeserializeObject<List<Facturasvtas>>(contenido);
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
        public static async Task<bool> Actualizar(Facturasvtas tarea)
        {

            var resultado = true;
            try
            {
                using (var client = new HttpClient())
                {
                    // enviar el token
                    //client.DefaultRequestHeaders.Add("token", Configuracion.Token);
                    var libroJson = JsonConvert.SerializeObject(tarea);
                    var contenidoSolicitud = new StringContent(libroJson, System.Text.Encoding.UTF8, "application/json");

                    var conexion = await client.PostAsync(Configuracion.urlbase + "tarea/Actualizar", contenidoSolicitud);

                    var contenidoRespuesta = await conexion.Content.ReadAsStringAsync();

                    resultado = JsonConvert.DeserializeObject<bool>(contenidoRespuesta);

                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("errores.log", "LibroClientws.insertar(): " + ex.Message + " "
                    + ex.InnerException.Message + " " + DateTime.Now.ToString() + "\n");
                resultado = false;
            }
            return resultado;
        }


        public static async Task<bool> Insertar(Facturasvtas fact)
        {
            var resultado = true;
           // try
           // {
                using (var client = new HttpClient())
                {
                    // enviar el token
                    //client.DefaultRequestHeaders.Add("token", Configuracion.Facturasvtas);
                    var facturaJson = JsonConvert.SerializeObject(fact);
                    var contenidoSolicitud = new StringContent(facturaJson, System.Text.Encoding.UTF8, "application/json");

                    var conexion = await client.PostAsync(Configuracion.urlbase + "/FacturaVta/insertar", contenidoSolicitud);

                    var contenidoRespuesta = await conexion.Content.ReadAsStringAsync();

                    resultado = JsonConvert.DeserializeObject<bool>(contenidoRespuesta);

                }
          /*  }
            catch (Exception ex)
            {
                File.AppendAllText("errores.log", "LibroClientws.insertar(): " + ex.Message + " "
                    + ex.InnerException.Message + " " + DateTime.Now.ToString() + "\n");
                resultado = false;
            }*/
            return resultado;

        }



    }
}
