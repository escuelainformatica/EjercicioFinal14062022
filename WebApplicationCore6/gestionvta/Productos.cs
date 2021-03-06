using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace WebApplication1.gestionvta
{
    public partial class Productos
    {
        public Productos()
        {
            Detalledctos = new HashSet<Detalledctos>();
        }

        public int Idproductos { get; set; }
        public string Descrispcion { get; set; }
        public int? Preciovta { get; set; }
        public int? Preciocom { get; set; }

        [JsonIgnore]
        public virtual ICollection<Detalledctos> Detalledctos { get; set; }
    }
}
