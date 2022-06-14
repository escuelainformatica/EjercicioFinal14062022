using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace WebApplication1.gestionvta
{
    public partial class Detalledctos
    {
        public string Tipodcto { get; set; }
        public int? Idfactvta { get; set; }
        public int? Nrodcto { get; set; }
        public string Rut { get; set; }
        public int? Idproductos { get; set; }
        public decimal? Cantidad { get; set; }
        public int? Precio { get; set; }
        public int? Total { get; set; }
        public string Detalledctoscol { get; set; }

        [JsonIgnore]
        public virtual Facturasvtas IdfactvtaNavigation { get; set; }
        public virtual Productos IdproductosNavigation { get; set; }
    }
}
