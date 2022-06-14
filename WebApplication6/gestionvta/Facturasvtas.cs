using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.gestionvta
{
    public partial class Facturasvtas
    {
        public Facturasvtas()
        {
            Detalledctos = new HashSet<Detalledctos>();
        }

        public int Idfactvta { get; set; }
        public string Tipodcto { get; set; }
        public int? Nrodcto { get; set; }
        public DateTime? Fechadcto { get; set; }
        public string Rut { get; set; }
        public int? Totalneto { get; set; }
        public int? Totaliva { get; set; }
        public int? Totalbruto { get; set; }
        public int? Totalpago { get; set; }
        public int? Totalsaldo { get; set; }
        public byte? Statusdcto { get; set; }

        public virtual ICollection<Detalledctos> Detalledctos { get; set; }
    }
}
