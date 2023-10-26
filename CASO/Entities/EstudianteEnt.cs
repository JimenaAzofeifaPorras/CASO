using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CASO.Entities
{
    public class EstudianteEnt
    {
        public long Consecutivo { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public int Monto { get; set; }
        public int TipoCurso { get; set; }
    }
}
