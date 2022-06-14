using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.gestionvta
{
    public partial class Clientes
    {
        public int Idclientes { get; set; }
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int? Montocredito { get; set; }
    }
}
