using System;
using System.Web.Http;
using ApiCASO.Entities;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace ApiCASO.Controllers
{
    public class LoginController : ApiController
    {

        [HttpPost]
        [Route("Matricular1")]
        public string Matricular1(UsuarioEnt entidad)
        {
            try
            {
                using (var context = new CasoEstudioMNEntities())
                {
                    var user = new Estudiantes();
                    user.Consecutivo = entidad.Consecutivo;
                    user.Nombre = entidad.Nombre;
                    user.Fecha = entidad.Fecha;
                    user.Monto = entidad.Monto;
                    user.TipoCurso = entidad.TipoCurso;

                    context.Estudiantes.Add(user);
                    context.SaveChanges();

                    return "Matrícula exitosa";
                }
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}
