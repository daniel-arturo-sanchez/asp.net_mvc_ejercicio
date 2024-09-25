using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Ejercicio_MVC2.Controllers
{
    public class SaludosController : Controller
    {
<<<<<<< HEAD
        public IActionResult Index()
        {
            return View();
=======
        public string Index(string? ID)
        {
            return $"Hola a {ID}";
>>>>>>> 7f0110e95dd1bb95fd45766ff10fe315e2cccdc2
        }

        public IActionResult Despedida()
        {
            return View();
        }
    }
}
