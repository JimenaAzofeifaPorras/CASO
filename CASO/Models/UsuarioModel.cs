using CASO.Entities;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Json;
using System.Web.Mvc;

namespace CASO.Models
{
    public class UsuarioModel
    {

        public string urlApi = ConfigurationManager.AppSettings["urlApi"];

        public string Matricular1(EstudianteEnt entidad)
        {
            using (var client = new HttpClient())
            {
                string url = urlApi + "Matricular1";
                JsonContent contenido = JsonContent.Create(entidad);
                var resp = client.PostAsync(url, contenido).Result;
                return resp.Content.ReadFromJsonAsync<string>().Result;
            }
        }

        public List<SelectListItem> ConsultarCursos()
        {
            using (var client = new HttpClient())
            {
                string url = urlApi + "ConsultarCursos";
                var resp = client.GetAsync(url).Result;
                return resp.Content.ReadFromJsonAsync<List<SelectListItem>>().Result;
            }
        }

        public List<EstudianteEnt> ConsultaUsuarios()
        {
            using (var client = new HttpClient())
            {
                var url = urlApi + "ConsultaUsuarios";
                var res = client.GetAsync(url).Result;
                return res.Content.ReadFromJsonAsync<List<EstudianteEnt>>().Result;
            }
        }

    }
}