using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeclaracionesServer.Models
{
    public class Gasolina
    {
        public int GasolinaId { get; set; }
        public string clase { get; set; }
        public float galones_gravado { get; set; }
        public float precio_referencia { get; set; }
        public float porcentaje_alcohol { get; set; }
        public float base_gravable { get; set; }
        public float sobretasa { get; set; }

        public int DeclaracionId { get; set; }
        //public virtual Declaracion Declaracion { get; set; }
    }
}
