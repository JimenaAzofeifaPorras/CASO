using System;

namespace ApiCASO.Entities
{
    public class UsuarioEnt
    {
        public long Consecutivo { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public int Monto { get; set; }
        public int TipoCurso { get; set; }
    }
}