using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiCASO.Controllers
{
    public class UsuarioController : ApiController
    {

            [HttpGet]
            [Route("ConsultaUsuarios")]
            public List<System.Web.Mvc.SelectListItem> ConsultaUsuarios()
            {
                try
                {
                    using (var context = new CasoEstudioMNEntities())
                    {
                        var datos = (from x in context.TiposCursos
                                     select x).ToList();

                        var respuesta = new List<System.Web.Mvc.SelectListItem>();
                        foreach (var item in datos)
                        {
                            respuesta.Add(new System.Web.Mvc.SelectListItem { Value = item.TipoCurso.ToString(), Text = item.DescripcionTipoCurso });
                        }

                        return respuesta;
                    }
                }
                catch (Exception)
                {
                    return null;
                }
            }

        [HttpGet]
        [Route("ConsultarCursos")]
        public List<System.Web.Mvc.SelectListItem> ConsultarCursos()
        {
            try
            {
                using (var context = new CasoEstudioMNEntities())
                {
                    var datos = (from x in context.TiposCursos
                                 select x).ToList();

                    var respuesta = new List<System.Web.Mvc.SelectListItem>();
                    foreach (var item in datos)
                    {
                        respuesta.Add(new System.Web.Mvc.SelectListItem { Value = item.TipoCurso.ToString(), Text = item.DescripcionTipoCurso });
                    }

                    return respuesta;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}