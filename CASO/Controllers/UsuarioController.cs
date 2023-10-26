using CASO.Models;
using System.Web.Mvc;

namespace CASO.Controllers
{
    public class UsuarioController : Controller
    {
        UsuarioModel model = new UsuarioModel();

        [HttpGet]
        public ActionResult ConsultaUsuarios()
        {
            var datos = model.ConsultaUsuarios();
            return View(datos);
        }

        public ActionResult ConsultarCursos()
        {
            var datos = model.ConsultarCursos();
            return View(datos);
        }

    }
}