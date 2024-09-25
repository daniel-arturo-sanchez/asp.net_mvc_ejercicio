using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Ejercicio_MVC2.Controllers
{
    public class SaludosController : Controller
    {
        public string Index(string? ID)
        {
            return $"Hola a {ID}";
        }

        public string Despedida(int ID, string nombre, string edad)
        {
            return $"El usuario con ID: {ID} y nombre {nombre} se despide a sus {edad} años";
        }
    }
}
