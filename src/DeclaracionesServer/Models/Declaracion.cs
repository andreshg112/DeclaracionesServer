using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeclaracionesServer.Models
{
    public class Declaracion
    {
        public int DeclaracionId { get; set; }
        public string entidad_departamento { get; set; }
        public string entidad_codigo_dane { get; set; }
        public string entidad_nit { get; set; }
        public string entidad_dv { get; set; }
        public string calidad_declarante { get; set; }
        public bool correccion_valor { get; set; }
        public string correccion_id { get; set; }
        public DateTime correccion_fecha { get; set; }
        public int anio { get; set; }
        public string mes { get; set; }
        public string nombres { get; set; }
        public string tipo_documento { get; set; }
        public string numero_documento { get; set; }
        public string dv { get; set; }
        public string direccion { get; set; }
        public string departamento { get; set; }
        public string municipio { get; set; }
        public string telefono { get; set; }

        public List<Gasolina> Gasolinas { get; set; }
    }
}
