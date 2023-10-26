using CASO.Entities;
using CASO.Models;
using System.Web.Mvc;

namespace CASO.Controllers
{
    public class LoginController : Controller
    {
        UsuarioModel usuarioModel = new UsuarioModel();


        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Matricular1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Matricular1(EstudianteEnt entidad)
        {
            var resp = usuarioModel.Matricular1(entidad);

            if (resp == "OK")
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                ViewBag.MensajeUsuario = "No se ha registrado su información";
                return View();
            }
        }

    }
}