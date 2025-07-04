using Microsoft.AspNetCore.Mvc;
using System.Security;
using System.Text.Encodings.Web;

namespace MVCPelicula_DH211056.Controllers
{
    public class HelloWorldController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Welcome(string nombre, string apellido, int numVeces = 1)
        {
            ViewData["nombre_apellido"] = $"{nombre} {apellido}";
            ViewData["numVeces"] = numVeces;

            return View();
        }
    }
}
