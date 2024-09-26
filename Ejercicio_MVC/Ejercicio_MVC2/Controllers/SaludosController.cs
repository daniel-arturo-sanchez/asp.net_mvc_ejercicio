using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Ejercicio_MVC2.Controllers
{
    public class SaludosController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Despedida()
        {
            return View();
        }

        public IActionResult Felicita(int ID, string nombre, int edad)
        {
            ViewBag.id = ID;
            ViewBag.nombre = nombre;
            ViewBag.edad = edad;
            return View();
        }
    }
}
