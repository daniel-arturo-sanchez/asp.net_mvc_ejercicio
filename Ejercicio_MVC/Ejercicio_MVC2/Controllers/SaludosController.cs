using Microsoft.AspNetCore.Mvc;

namespace Ejercicio_MVC2.Controllers
{
    public class SaludosController : Controller
    {
        public string Index()
        {
            return "Hola mundo";
        }

        public string Despedida()
        {
            return "Adiós mundo";
        }
    }
}
